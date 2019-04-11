using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartPhone.Data;
using SmartPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartPhone.Controllers
{
    [Route("admin")]
    public class OrdersController : Controller
    {
        private readonly DataContext _context;
        private readonly Random random = new Random();
        public OrdersController(DataContext context)
        {
            _context = context;
        }
        
        public List<Order> ShowOrderList(List<Order> listOrder) 
        {
            var codeOld = "";
            var list = new List<Order>();
            foreach (var item in listOrder)
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
            return list;
        }


        [HttpGet("order")]
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Orders.Include(x=>x.PaymentMethod).OrderByDescending(x => x.CreatedAt).ToList();
            return View(ShowOrderList(dataContext));
        }


        [HttpGet, Route("order/search")]
        public async Task<IActionResult> Search([FromQuery]string query)
        {
            var list = _context.Orders.OrderByDescending(x => x.CreatedAt).ToList();
            var dataContext = ShowOrderList(list);

            var orders = new List<Order>();

            if (!String.IsNullOrEmpty(query))
            {
                foreach (var item in dataContext)
                {
                    if (item.Code.ToLower().Contains(query.ToLower()))
                    {
                        orders.Add(item);
                    }
                }
            }
            return orders.Count == 0 ? View("Index", dataContext) : View("Index", orders);
        }
        
        [HttpGet, Route("edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }

            var orders = _context.Orders.Include(x => x.Product).Where(x => x.Code == id).ToList();
            if (orders == null)
            {
                return NotFound();
            }
            return View(orders);
        }
        
        [HttpPost, Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet, Route("delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);

            var orders = await _context.Orders.Where(x=> x.Code == order.Code).ToListAsync();

            _context.Orders.RemoveRange(orders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        } 
    }
}
