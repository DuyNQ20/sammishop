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
            var dataContext = _context.Carts.Include(c => c.Product).Include(c => c.User).Include(c=>c.Product.Files).Include(c=>c.Product.Supplier);
            
            return View(await dataContext.ToListAsync());
        }

        // GET: Carts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts
                .Include(c => c.Product)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }
            return View(cart);
        }
        
        public async Task<IActionResult> AddToCart(int id)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(x=>x.ProductId == id);

            if(cart != null)
            {
                cart.Quantity++;
                _context.Carts.Update(cart);
                await _context.SaveChangesAsync();
            }
            else
            {
                var cartView = new CartView
                {
                    UserId = HttpContext.Session.GetInt32("CustomerID") == null ? HttpContext.Session.GetInt32("CustomerID") : null,
                    ProductId = id,
                    Active = true,
                    Quantity = 1
                };
                cart = new Cart();
                cart.SaveMap(cartView);
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }



        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Carts.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

      

        private bool CartExists(int id)
        {
            return _context.Carts.Any(e => e.Id == id);
        }
    }
}
