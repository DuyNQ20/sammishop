using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Sammishop.Data;
using Sammishop.Lib;
using Sammishop.Mapper;
using Sammishop.Models;
using Sammishop.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Sammishop.Controllers
{
    public class CartsController : Controller
    {
        private readonly DataContext _context;
        public CartsController(DataContext context)
        {
            _context = context;
        }

        public List<Cart> GetCarts()
        {
            var dataContext = new List<Cart>();
            if (HttpContext.Session.GetInt32("CustomerID") != null)
            {
                dataContext = _context.Carts.Include(c => c.Product).Include(c => c.User).Include(c => c.Product.Files).Include(c => c.Product.Supplier).Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToList();
            }
            else
            {
                dataContext = HttpContext.Session.GetObject<List<Cart>>("Carts");
            }

            return dataContext;
        }

        // GET: Carts
        [HttpGet("checkout/cart")]
        public async Task<IActionResult> Index()
        {
            var dataContext = GetCarts();
            ViewData["Discount"] = HttpContext.Session.GetObject<Discount>("Discount");
            ViewData["DiscountNotify"] = DiscountsController.DiscountNotify;

            return View(dataContext);
        }

        // Kiểm tra mã giảm giá hợp lệ
        [HttpGet("checkout/discount")]
        public async Task<IActionResult> checkDiscount(string code)
        {
            DiscountsController.DiscountNotify = "";
            HttpContext.Session.Remove("Discount");
            HttpContext.Session.Remove("DiscountNotify");
            var discount = await _context.Discounts.FirstOrDefaultAsync(x => x.Code == code & x.Quantity > 0 & x.Active == true);
            bool check = true;
            if (discount != null)
            {
                if (discount.ApplyAll==false)
                {
                    var Carts = GetCarts();
                    foreach (var item in Carts)
                    {
                        var checkDiscountProduct = _context.DiscountProducts.FirstOrDefault(x => x.DiscountId == discount.Id & x.ProductId == item.ProductId);
                        var checkDiscountProductCategory = _context.DiscountProductCategories.FirstOrDefault(x => x.DiscountId == discount.Id & x.ProductCategoryId == item.Product.ProductCategoryId);
                        if (checkDiscountProduct == null && checkDiscountProductCategory == null) // Nếu 1 trong số sp trong giỏ hàng k thuộc ngành giảm giá
                        {
                            check = false; // không cho áp dụng
                            break;
                        }

                    }
                }


            }
            else
            {
                check = false;
            }

            if (check)
            {
                HttpContext.Session.SetObject("Discount", discount);
            }
            else
            {
                DiscountsController.DiscountNotify = "Mã giảm giá không hợp lệ";
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> AddToCartPost(int id, int quantity = 1)
        {
            var product = _context.Products.Find(id);
            if (product.Inventory >= quantity)
            {
                // Nếu có User đăng nhập
                if (HttpContext.Session.GetInt32("CustomerID") != null)
                {
                    var cart = await _context.Carts.FirstOrDefaultAsync(x => x.ProductId == id & x.UserId == HttpContext.Session.GetInt32("CustomerID"));

                    if (cart != null) // đã có sp trong giỏ hàng
                    {
                        cart.Quantity = quantity;
                        if (cart.Quantity <= product.Inventory)
                        {
                            _context.Carts.Update(cart);
                            await _context.SaveChangesAsync();
                        }
                        // HttpContext.Session.SetObject("Carts", _context.Carts.Include(x=>x.Product).Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToList());
                    }
                    else // Nếu giỏ hàng chưa có gì
                    {
                        var cartView = new CartView
                        {
                            UserId = HttpContext.Session.GetInt32("CustomerID"),
                            ProductId = id,
                            Active = true,
                            Quantity = quantity
                        };

                        cart = new Cart();
                        cart.SaveMap(cartView);
                        _context.Carts.Add(cart);
                        await _context.SaveChangesAsync();
                        // HttpContext.Session.SetObject("Carts", _context.Carts.Include(x => x.Product).Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToList());
                        //return RedirectToAction("Index", "Home");
                    }
                }
                else // Nếu chưa đăng nhập
                {
                    var _listCarts = new List<Cart>();

                    var cart = new Cart()
                    {
                        UserId = null,
                        ProductId = id,
                        Active = true,
                        Quantity = quantity,
                        Product = _context.Products.Include(c => c.Files).Include(c => c.Supplier).FirstOrDefault(x => x.Id == id)
                    };

                    // Nếu giỏ hàng chưa có gì
                    if (HttpContext.Session.GetObject<List<Cart>>("Carts") == null)
                    {
                        _listCarts.Add(cart);

                        HttpContext.Session.SetObject("Carts", _listCarts.ToList());
                    }
                    else
                    {
                        _listCarts = HttpContext.Session.GetObject<List<Cart>>("Carts");
                        if (_listCarts.FirstOrDefault(x => x.ProductId == id) != null)
                        {
                            if ((_listCarts.FirstOrDefault(x => x.ProductId == id).Quantity + 1) <= product.Inventory)
                            {
                                _listCarts.FirstOrDefault(x => x.ProductId == id).Quantity = quantity;
                            }
                        }
                        else
                        {
                            _listCarts.Add(cart);
                        }

                        HttpContext.Session.SetObject("Carts", _listCarts);
                    }

                }

            }

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> AddToCart(int id, int quantity = 1)
        {
            var product = _context.Products.Find(id);
            if (product.Inventory >= quantity)
            {
                // Nếu có User đăng nhập
                if (HttpContext.Session.GetInt32("CustomerID") != null)
                {
                    var cart = await _context.Carts.FirstOrDefaultAsync(x => x.ProductId == id & x.UserId == HttpContext.Session.GetInt32("CustomerID"));

                    if (cart != null) // đã có sp trong giỏ hàng
                    {
                        cart.Quantity = cart.Quantity + quantity;
                        if (cart.Quantity <= product.Inventory)
                        {
                            _context.Carts.Update(cart);
                            await _context.SaveChangesAsync();
                        }
                        // HttpContext.Session.SetObject("Carts", _context.Carts.Include(x=>x.Product).Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToList());
                    }
                    else // Nếu giỏ hàng chưa có gì
                    {
                        var cartView = new CartView
                        {
                            UserId = HttpContext.Session.GetInt32("CustomerID"),
                            ProductId = id,
                            Active = true,
                            Quantity = quantity
                        };

                        cart = new Cart();
                        cart.SaveMap(cartView);
                        _context.Carts.Add(cart);
                        await _context.SaveChangesAsync();
                        // HttpContext.Session.SetObject("Carts", _context.Carts.Include(x => x.Product).Where(x => x.UserId == HttpContext.Session.GetInt32("CustomerID")).ToList());
                        //return RedirectToAction("Index", "Home");
                    }
                }
                else // Nếu chưa đăng nhập
                {
                    var _listCarts = new List<Cart>();

                    var cart = new Cart()
                    {
                        UserId = null,
                        ProductId = id,
                        Active = true,
                        Quantity = quantity,
                        Product = _context.Products.Include(c => c.Files).Include(c => c.Supplier).FirstOrDefault(x => x.Id == id)
                    };

                    // Nếu giỏ hàng chưa có gì
                    if (HttpContext.Session.GetObject<List<Cart>>("Carts") == null)
                    {
                        _listCarts.Add(cart);

                        HttpContext.Session.SetObject("Carts", _listCarts.ToList());
                    }
                    else
                    {
                        _listCarts = HttpContext.Session.GetObject<List<Cart>>("Carts");
                        if (_listCarts.FirstOrDefault(x => x.ProductId == id) != null)
                        {
                            if ((_listCarts.FirstOrDefault(x => x.ProductId == id).Quantity + 1) <= product.Inventory)
                            {
                                _listCarts.FirstOrDefault(x => x.ProductId == id).Quantity+=quantity;
                            }
                        }
                        else
                        {
                            _listCarts.Add(cart);
                        }

                        HttpContext.Session.SetObject("Carts", _listCarts);
                    }

                }

            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AddProductQuantityFromCart(int id)
        {
            var product = _context.Products.Find(id);
            if (HttpContext.Session.GetInt32("CustomerID") != null)
            {
                var cart = await _context.Carts.FirstOrDefaultAsync(x => x.ProductId == id & x.UserId == HttpContext.Session.GetInt32("CustomerID"));

                if (cart != null)
                {
                    cart.Quantity++;
                    if (cart.Quantity <= product.Inventory)
                    {
                        _context.Carts.Update(cart);
                        await _context.SaveChangesAsync();
                    }


                }
            }
            else
            {
                var _listCarts = HttpContext.Session.GetObject<List<Cart>>("Carts");
                if ((_listCarts.FirstOrDefault(x => x.ProductId == id).Quantity + 1) <= product.Inventory)
                {
                    _listCarts.FirstOrDefault(x => x.ProductId == id).Quantity++;
                    HttpContext.Session.SetObject("Carts", _listCarts);
                }

            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RemoveProductQuantityFromCart(int id)
        {
            if (HttpContext.Session.GetInt32("CustomerID") != null) // đã đăng nhập
            {
                var cart = await _context.Carts.FirstOrDefaultAsync(x => x.ProductId == id & x.UserId == HttpContext.Session.GetInt32("CustomerID"));

                if (cart != null && cart.Quantity > 1)
                {
                    cart.Quantity--;
                    _context.Carts.Update(cart);
                    await _context.SaveChangesAsync();
                }
            }
            else // chưa đăng nhập
            {

                var _listCarts = HttpContext.Session.GetObject<List<Cart>>("Carts");
                var cart = _listCarts.FirstOrDefault(x => x.ProductId == id);
                if (cart != null && cart.Quantity > 1) // không cho trừ nếu là 1
                {
                    _listCarts.FirstOrDefault(x => x.ProductId == id).Quantity--;
                    HttpContext.Session.SetObject("Carts", _listCarts);
                }

            }

            return RedirectToAction(nameof(Index));

        }



        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (HttpContext.Session.GetInt32("CustomerID") != null) // đã đăng nhập
            {
                var cart = _context.Carts.Where(x => x.ProductId == id & x.UserId == HttpContext.Session.GetInt32("CustomerID"));
                if (cart == null)
                {
                    return NotFound();
                }
                _context.Carts.RemoveRange(cart);
                await _context.SaveChangesAsync();
            }
            else
            {
                var _listCarts = HttpContext.Session.GetObject<List<Cart>>("Carts");
                var cart = _listCarts.FirstOrDefault(x => x.ProductId == id);
                _listCarts.Remove(cart);
                HttpContext.Session.SetObject("Carts", _listCarts);
            }


            return RedirectToAction(nameof(Index));
        }

    }
}
