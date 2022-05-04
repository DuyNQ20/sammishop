using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using Sammishop.Data;
using Sammishop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sammishop.Controllers
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
        
        [HttpGet("order")]
        public IActionResult Index()
        {
            var dataContext = _context.Orders.Include(x=>x.PaymentMethod).Include(x => x.orderStatus).OrderByDescending(x => x.CreatedAt).ToList();
            ViewBag.OrderStatus = "";

            return View(Common.ShowOrderList(dataContext));
        }

        [HttpGet("ordercancel")]
        public async Task<IActionResult> OrderCancel(string id)
        {
            var orders = _context.Orders.Where(x => x.Code == id).ToList();
            foreach (var item in orders)
            {
                item.OrderStatusId = 4; // id hủy đơn hàng
                _context.Update(item);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet("done/{id}")]
        public async Task<IActionResult> Done(string id)
        {
            var orders = _context.Orders.Where(x => x.Code == id).ToList();
            foreach (var item in orders)
            {
                item.OrderStatusId = 3; // id hủy đơn hàng
                _context.Update(item);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet("order/pending")]
        public async Task<IActionResult> OrderPending()
        {
            var dataContext = _context.Orders
            .Include(x=>x.PaymentMethod)
            .Include(x => x.orderStatus)
            .Where(x => x.OrderStatusId == 1) // 1 đang chờ
            .OrderByDescending(x => x.CreatedAt).ToList();
            ViewBag.OrderStatus = "";

            return View(Common.ShowOrderList(dataContext));
        }

        [HttpGet("order/delivering")]
        public async Task<IActionResult> OrderDelivering()
        {
            var dataContext = _context.Orders
            .Include(x=>x.PaymentMethod)
            .Include(x => x.orderStatus)
            .Where(x => x.OrderStatusId == 2) // 1 đang chờ
            .OrderByDescending(x => x.CreatedAt).ToList();
            ViewBag.OrderStatus = "";

            return View(Common.ShowOrderList(dataContext));
        }

        [HttpGet("order/delivered")]
        public async Task<IActionResult> OrderDelivered()
        {
            var dataContext = _context.Orders
            .Include(x=>x.PaymentMethod)
            .Include(x => x.orderStatus)
            .Where(x => x.OrderStatusId == 3) // 1 đang chờ
            .OrderByDescending(x => x.CreatedAt).ToList();
            ViewBag.OrderStatus = "";

            return View(Common.ShowOrderList(dataContext));
        }

        [HttpGet("order/cancel")]
        public async Task<IActionResult> OrderCancel()
        {
            var dataContext = _context.Orders
            .Include(x=>x.PaymentMethod)
            .Include(x => x.orderStatus)
            .Where(x => x.OrderStatusId == 4) // 1 đang chờ
            .OrderByDescending(x => x.CreatedAt).ToList();
            ViewBag.OrderStatus = "";

            return View(Common.ShowOrderList(dataContext));
        }

        [HttpGet, Route("order/search")]
        public async Task<IActionResult> Search([FromQuery]string query)
        {
            // var list = _context.Orders.OrderByDescending(x => x.CreatedAt).ToList();
            // var dataContext = Common.ShowOrderList(list);

            // var orders = new List<Order>();
            var dataContext = _context.Orders.AsQueryable();
            if (!String.IsNullOrEmpty(query))
            {
                dataContext = dataContext.Where(x => x.Code.ToLower().Contains(query.ToLower()));
                // foreach (var item in dataContext)
                // {
                //     if (item.Code.ToLower().Contains(query.ToLower()))
                //     {
                //         orders.Add(item);
                //     }
                // }
            }
           
            
            return View("Index", dataContext.OrderByDescending(x => x.CreatedAt));
        }
        
        [HttpGet, Route("edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }

            var orders = _context.Orders.Include(x => x.Product).Include(x=>x.orderStatus).Include(x=>x.User).Where(x => x.Code == id).ToList();
            if (orders == null)
            {
                return NotFound();
            }
            return View(orders);
        }
        
        [HttpPost, Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, string Receiver, string Phone, string DeliveryAddress, string Note)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }
            // Cập nhật thông tin giao hàng nếu khách hàng có yêu cầu
            var orders = _context.Orders.Where(x => x.Code == id).ToList();
            foreach(var item in orders)
            {
                item.Receiver = Receiver;
                item.Phone = Phone;
                item.DeliveryAddress = DeliveryAddress;
                item.Note = Note;
                item.OrderStatusId = 2;
                _context.Update(item);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Bill", new { idd = id });
        }


        [HttpGet, Route("bill/{idd}")]
        public async Task<IActionResult> Bill(string idd)
        {
            string id = idd;
            if (id == null || id == "")
            {
                return NotFound();
            }

            var orders = _context.Orders.Include(x => x.Product).Include(x => x.User).Include(x=>x.PaymentMethod).Where(x => x.Code == id).ToList();
            // thay đổi lại trạng thái đơn hàng
            foreach(var item in orders)
            {
                item.OrderStatusId = 2; // Sang trạng thái đang giao hàng
                _context.Update(item);
            }
            _context.SaveChanges();
            if (orders == null)
            {
                return NotFound();
            }
            return View(orders);
        }

        [HttpPost, Route("bill/{id}")]
        public async Task<IActionResult> Print(string id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }

            var orders = _context.Orders.Include(x => x.Product).Include(x => x.User).Include(x => x.PaymentMethod).Where(x => x.Code == id).ToList();
            if (orders == null)
            {
                return NotFound();
            }
            return new ViewAsPdf(orders);
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
