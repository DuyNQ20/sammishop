using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartPhone.Data;
using SmartPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rotativa.AspNetCore;

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
            var dataContext = _context.Orders.Include(x=>x.PaymentMethod).Include(x => x.orderStatus).OrderByDescending(x => x.CreatedAt).ToList();
            ViewBag.OrderStatus = "";

            return View(ShowOrderList(dataContext));
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
