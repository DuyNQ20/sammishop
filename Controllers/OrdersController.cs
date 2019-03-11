using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartPhone.Data;
using SmartPhone.Lib;
using SmartPhone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartPhone.Controllers
{
    [Route("checkout")]
    public class OrdersController : Controller
    {
        private readonly DataContext _context;

        public OrdersController(DataContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
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
    }
}
