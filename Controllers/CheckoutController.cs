using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sammishop.Data;
using Sammishop.Lib;
using Sammishop.Mapper;
using Sammishop.Models;
using Sammishop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Sammishop.Controllers
{
    [Route("checkout")]
    public class CheckoutController : Controller
    {
        private readonly DataContext _context;
        private readonly Random random = new Random();

        public CheckoutController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("shipping")]
        public async Task<IActionResult> Index()
        {
            var dataContext = new List<Cart>();
            if (HttpContext.Session.GetInt32("CustomerID") != null)
            {
                dataContext = await _context.Carts
                .Include(c => c.Product)
                .Include(c => c.User)
                .Include(c => c.Product.Files)
                .Include(c => c.Product.Supplier)
                .Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToListAsync();
            }
            else
            {
                dataContext = HttpContext.Session.GetObject<List<Cart>>("Carts");

                //return RedirectToAction("HomeLogin", "Account");
            }
            ViewData["Discount"] = HttpContext.Session.GetObject<Discount>("Discount");
            ViewBag.Code = random.Next(10000000, 999999999);
            return View(dataContext);
        }


        [HttpPost("order")]
        public async Task<IActionResult> Order(OrderView orderView, string code)
        {

            if (_context.Orders.FirstOrDefault(x => x.Code == code) != null)
            {
                ViewData["Code"] = "#" + code;
                return View();
            }


            var dataContext = new List<Cart>();

            if (HttpContext.Session.GetInt32("CustomerID") != null)
            {
                dataContext = await _context.Carts.Include(c => c.Product).Include(c => c.User).Include(c => c.Product.Files).Include(c => c.Product.Supplier).Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToListAsync();
            }
            else
            {
                dataContext = HttpContext.Session.GetObject<List<Cart>>("Carts");
            }

            //var code = random.Next(10000000, 999999999);
            decimal total = 0;

            foreach (var item in dataContext)
            {
                total += item.Product.SalePrice * item.Quantity;
            }

            var discount = HttpContext.Session.GetObject<Discount>("Discount"); // lấy mã giảm giá nếu có
            foreach (var item in dataContext)
            {
                Order order = new Order();
                orderView.UserId = HttpContext.Session.GetInt32("CustomerID");
                orderView.ProductId = item.ProductId;
                orderView.Quantity = item.Quantity;
                orderView.SalePrice = item.Product.SalePrice;
                orderView.Code = code;
                orderView.DiscountMoney = discount == null ? 0 : discount.DiscountMoney;
                orderView.Total = total - (discount == null ? 0 : discount.DiscountMoney);

                order.SaveMap(orderView);
                _context.Orders.Add(order);
            }

            // Xóa cart
            var cartList = _context.Carts.Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToList();
            if (cartList != null)
            {
                _context.Carts.RemoveRange(cartList);
            }

            // Cập nhật lại số lượng tồn trong kho
            foreach (var item in dataContext)
            {
                var product = _context.Products.Find(item.ProductId);
                if (product != null)
                {
                    product.Inventory -= item.Quantity;
                }
                _context.Update(product);
            }

            // Giảm số lượng mã giảm giá
            if (discount != null)
            {
                discount.Quantity--;
                _context.Update(discount);
                HttpContext.Session.Remove("Discount");
            }

            await _context.SaveChangesAsync();
            ViewData["Code"] = "#" + code;
            return View();
        }
    }
}