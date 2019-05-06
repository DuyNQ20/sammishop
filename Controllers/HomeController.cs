using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartPhone.Data;
using SmartPhone.Lib;
using SmartPhone.Mapper;
using SmartPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Products.Include(p => p.Files).Include(x => x.ProductCategory);

            // Kiểm tra trả về lịch sử đã xem cho user
            ViewData["History"] = null;
            if (HttpContext.Session.GetInt32("CustomerID") != null)
            {
                ViewData["History"] = _context.Histories.Include(x=>x.Product).ThenInclude(x=>x.Files).ToList();
                //HttpContext.Session.SetObject("Carts", _context.Carts.Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToList());
            }

            return View(await dataContext.ToListAsync());
        }

        // GET: Home/Details/5
        [HttpGet, Route("details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.Status)
                .Include(p => p.Supplier)
                .Include(p => p.Files)
                .FirstOrDefaultAsync(m => m.Id == id);


            // Nếu đã đăng nhập thì thêm vào db sản phẩm đã xem

            if (HttpContext.Session.GetInt32("CustomerID") != null)
            {
                var history = _context.Histories.FirstOrDefault(x => x.UserId == HttpContext.Session.GetInt32("CustomerID") & x.ProductId == product.Id);
                if (history == null)
                {
                    var historyView = new ViewModels.HistoryView() { ProductId = product.Id, UserId = HttpContext.Session.GetInt32("CustomerID"), Active = true };
                    var historySave = new History();
                    historySave.SaveMap(historyView);
                    _context.Histories.Add(historySave);
                    _context.SaveChanges();
                }
            }


            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpGet, Route("search")]
        public async Task<IActionResult> Search([FromQuery]string query)
        {
            var dataContext = _context.Products.Include(p => p.Files).Include(x => x.ProductCategory).ToList();
            var products = new List<Product>();

            if (!String.IsNullOrEmpty(query))
            {
                foreach (var item in dataContext)
                {
                    if (item.Name.ToLower().Contains(query.ToLower()))
                    {
                        products.Add(item);
                    }
                }
            }
            return products.Count == 0 ? View("index", dataContext) : View("index", products);
        }


        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }




        // check ma giam gia con han su dung hay k?

        [HttpGet("discount/check")]
        public void UpdateStatus()
        {
            var discountList = _context.Discounts.ToList();
            foreach (var discount in discountList)
            {
                if (discount != null)
                {
                    discount.Active = discount.DateTimeFinish < DateTime.Now.Date ? false : true;
                    _context.Update(discount);
                }
            }
            _context.SaveChangesAsync();
        }

        // MyOrder  -- Đơn hàng của tôi
        [HttpGet, Route("order/history")]
        public async Task<IActionResult> MyOrder()
        {
            var orders = _context.Orders.Include(x => x.Product).Include(x => x.orderStatus).Include(x => x.PaymentMethod).Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).OrderBy(x => x.CreatedAt).ToList();
            return View(ShowOrderList(orders));
        }

        [HttpGet, Route("order/history/detail/{id}")]
        public async Task<IActionResult> MyOrderDetail(string id)
        {
            var orders = _context.Orders.Include(x => x.Product).Include(x => x.orderStatus).Include(x => x.PaymentMethod).Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID") & x.Code == id).ToList();
            return View(orders);
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

            return RedirectToAction(nameof(MyOrder));
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

    }
}
