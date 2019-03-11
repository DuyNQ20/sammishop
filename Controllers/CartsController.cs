using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartPhone.Data;
using SmartPhone.Models;
using SmartPhone.Mapper;
using SmartPhone.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SmartPhone.Lib;

namespace SmartPhone.Controllers
{
    public class CartsController : Controller
    {
        private readonly DataContext _context;
        public CartsController(DataContext context)
        {
            _context = context;
        }

        // GET: Carts
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


        public async Task<IActionResult> AddToCart(int id, int quantity = 1)
        {
            // Nếu có User đăng nhập
            if (HttpContext.Session.GetInt32("CustomerID") != null)
            {
                var cart = await _context.Carts.FirstOrDefaultAsync(x => x.ProductId == id & x.UserId == HttpContext.Session.GetInt32("CustomerID"));

                if (cart != null) // đã có sp trong giỏ hàng
                {
                    cart.Quantity = cart.Quantity + quantity;
                    _context.Carts.Update(cart);
                    await _context.SaveChangesAsync();
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
                    return RedirectToAction("Index", "Home");
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
                        _listCarts.FirstOrDefault(x => x.ProductId == id).Quantity++;
                    }
                    else
                    {
                        _listCarts.Add(cart);
                    }

                    HttpContext.Session.SetObject("Carts", _listCarts);
                }

            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> AddProductQuantityFromCart(int id)
        {
            if (HttpContext.Session.GetInt32("CustomerID") != null)
            {
                var cart = await _context.Carts.FirstOrDefaultAsync(x => x.ProductId == id);

                if (cart != null && cart.Quantity > 1)
                {
                    cart.Quantity++;
                    _context.Carts.Update(cart);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                var _listCarts = HttpContext.Session.GetObject<List<Cart>>("Carts");
                _listCarts.FirstOrDefault(x => x.ProductId == id).Quantity++;
                HttpContext.Session.SetObject("Carts", _listCarts);
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RemoveProductQuantityFromCart(int id)
        {
            if (HttpContext.Session.GetInt32("CustomerID") != null) // đã đăng nhập
            {
                var cart = await _context.Carts.FirstOrDefaultAsync(x => x.ProductId == id);

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
                var cart = await _context.Carts.FindAsync(id);
                if (cart == null)
                {
                    return NotFound();
                }
                _context.Carts.Remove(cart);
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
