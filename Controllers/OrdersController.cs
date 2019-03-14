using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartPhone.Data;
using SmartPhone.Lib;
using SmartPhone.Mapper;
using SmartPhone.Models;
using SmartPhone.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartPhone.Controllers
{
    [Route("")]
    public class OrdersController : Controller
    {
        private readonly DataContext _context;
        private readonly Random random = new Random();
        public OrdersController(DataContext context)
        {
            _context = context;
        }

       [HttpGet("checkout/shipping")]
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
            return View(dataContext);
        }

       
        [HttpPost("checkout/shipping")]
        public async Task<IActionResult> Order(OrderView orderView)
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

            var code = random.Next(10000000, 999999999);
            decimal total = 0;

            foreach(var item in dataContext)
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
                orderView.Code = "#"+code;
                orderView.Total = total;

                order.SaveMap(orderView);
                _context.Orders.Add(order);
            }



            await _context.SaveChangesAsync();

            ViewData["Code"] = code;
            return View();
        }



        //-------------------------------------------------------- Admin --------------------------------------------------------------

        [HttpGet("admin/order")]
        public async Task<IActionResult> GetAll()
        {
            var dataContext = _context.Orders.OrderByDescending(x=>x.CreatedAt).ToList();
            var list = new List<Order>();
            var codeOld = "";
            foreach (var item in dataContext)
            {
                var codeNew = item.Code;
                if (codeNew != codeOld)
                {
                    list.Add(item);
                }
                else
                {

                }
                codeOld = codeNew;
            }


            return View(list);
        }



    }
}
