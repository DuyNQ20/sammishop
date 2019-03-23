using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartPhone.Data;
using SmartPhone.Lib;
using SmartPhone.Mapper;
using SmartPhone.Models;
using SmartPhone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.Controllers
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
                dataContext = await _context.Carts.Include(c => c.Product).Include(c => c.User).Include(c => c.Product.Files).Include(c => c.Product.Supplier).Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToListAsync();
            }
            else
            {
                dataContext = HttpContext.Session.GetObject<List<Cart>>("Carts");
            }

            ViewBag.Code = "#" + random.Next(10000000, 999999999);
            return View(dataContext);
        }


        [HttpPost("order")]
        public async Task<IActionResult> Order(OrderView orderView, string code)
        {
            if (_context.Orders.FirstOrDefault(x => x.Code == code) != null)
            {
                ViewData["Code"] = code;
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

            foreach (var item in dataContext)
            {
                Order order = new Order();
                orderView.UserId = HttpContext.Session.GetInt32("CustomerID");
                orderView.ProductId = item.ProductId;
                orderView.Quantity = item.Quantity;
                orderView.SalePrice = item.Product.SalePrice;
                orderView.Code = code;
                orderView.Total = total;

                order.SaveMap(orderView);
                _context.Orders.Add(order);
            }

            // Xóa cart
            var cartList = _context.Carts.Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToList();
            if(cartList != null)
            {
                _context.Carts.RemoveRange(cartList);
            }
            await _context.SaveChangesAsync();

            
            
            ViewData["Code"] = code;
            return View();
        }
    }
}