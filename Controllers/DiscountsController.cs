using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartPhone.Data;
using SmartPhone.Mapper;
using SmartPhone.Models;
using SmartPhone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.Controllers
{
    [Route("admin/discounts")]
    public class DiscountsController : Controller
    {
        private readonly DataContext _context;

        public DiscountsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Discounts.ToListAsync());
        }

        [HttpGet, Route("update/status/{id}")]
        public async Task<IActionResult> UpdateStatus(int? id)
        {
            var discount = _context.Discounts.Find(id);
            if (discount == null)
            {
                return NotFound();
            }
            discount.Active = !discount.Active;
            _context.Entry(discount).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductCategories/Create
        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DiscountView discountView)
        {
            Discount discount = new Discount();
            discount.Map(discountView);
            if (ModelState.IsValid)
            {
                _context.Add(discount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(discount);
        }



        [HttpGet, Route("edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var discount = await _context.Discounts.Include(x=>x.DiscountProductCategories).Include(x=>x.DiscountProducts).FirstOrDefaultAsync(x => x.Id == id);
            if (discount == null)
            {
                return NotFound();
            }

            // Thêm list Selected để view multiSelect ProductCategory
            var listProductCategory = new List<ProductCategory>();
            listProductCategory.Add(new ProductCategory() { Name = "Chọn danh mục áp dụng" });
            listProductCategory.AddRange(_context.ProductCategorys.ToList());
            
            var ProductCategorySelected = new List<ProductCategory>();
            foreach(var item in discount.DiscountProductCategories)
            {
               ProductCategorySelected.Add(_context.ProductCategorys.Find(item.ProductCategoryId));
            }

            // Thêm list Selected để view multiSelect Product
            var listProduct = new List<Product>();
            listProduct.Add(new Product() { Name = "Chọn sản phẩm áp dụng" });
            listProduct.AddRange(_context.Products.ToList());

            var ProductSelected = new List<Product>();
            foreach (var item in discount.DiscountProducts)
            {
                ProductSelected.Add(_context.Products.Find(item.ProductId));
            }

            ViewBag.DiscountProductCategoryId = new MultiSelectList(listProductCategory, "Id", "Name", ProductCategorySelected.Select(x=>x.Id).ToArray());
            ViewBag.DiscountProductId = new MultiSelectList(listProduct, "Id", "Name", ProductSelected.Select(x=>x.Id).ToArray());
            ViewData["DiscountCategoryId"] = new SelectList(_context.DiscountCategories, "Id", "Decriptions", discount.DiscountCategoryId);
            return View(discount);
        }


        public List<DiscountProductCategory> GetDiscountProductCategory(int discountId, int[] DiscountProductCategoryId)
        {
            var discountProductCategories = new List<DiscountProductCategory>();
            foreach (var productCategoryId in DiscountProductCategoryId)
            {
                var discountProductCategory = new DiscountProductCategory();
                discountProductCategory.SaveMap(new DiscountProductCategoryView()
                {
                    DiscountId = discountId,
                    ProductCategoryId = productCategoryId,
                    Active = true
                });
                discountProductCategories.Add(discountProductCategory);
            }
            return discountProductCategories;
        }

        public List<DiscountProduct> GetDiscountProduct(int discountId, int[] DiscountProductId)
        {
            var discountProducts = new List<DiscountProduct>();
            foreach (var productId in DiscountProductId)
            {
                var discountProduct = new DiscountProduct();
                discountProduct.SaveMap(new DiscountProductView()
                {
                    DiscountId = discountId,
                    ProductId = productId,
                    Active = true
                });
                discountProducts.Add(discountProduct);
            }
            return discountProducts;
        }

        [ValidateAntiForgeryToken]
        [HttpPost, Route("edit/{id}")]
        public async Task<IActionResult> Edit(int id, DiscountView discountView, int[] DiscountProductCategoryId, int[] DiscountProductId)
        {
            var discount = _context.Discounts.Find(id);

            if (discount == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    discount.Map(discountView);
                    _context.Update(discount);


                    // cập nhật lại Mã giảm giá cho DiscountProductCategory
                    _context.RemoveRange(_context.DiscountProductCategories.Where(x => x.DiscountId == id)); // Xóa tất cả
                    _context.AddRange(GetDiscountProductCategory(id, DiscountProductCategoryId));

                    // cập nhật lại Mã giảm giá cho DiscountProduct
                    _context.RemoveRange(_context.DiscountProducts.Where(x => x.DiscountId == id)); // Xóa tất cả
                    _context.AddRange(GetDiscountProduct(id, DiscountProductId));

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiscountExists(discount.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(discount);
        }

        [HttpGet, Route("delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var discount = await _context.Discounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (discount != null)
            {
                _context.Discounts.Remove(discount);
                await _context.SaveChangesAsync();

            }
            return RedirectToAction(nameof(Index));
        }

        private bool DiscountExists(int id)
        {
            return _context.Discounts.Any(e => e.Id == id);
        }

        [HttpGet, Route("search")]
        public async Task<IActionResult> Search([FromQuery]string query)
        {
            var dataContext = _context.Discounts.Where(x=>x.Descriptions == query).ToList();
            var discount = new List<Discount>();

            if (!String.IsNullOrEmpty(query))
            {
                foreach (var item in dataContext)
                {
                    if (item.Descriptions.ToLower().Contains(query.ToLower()))
                    {
                        discount.Add(item);
                    }
                }
            }
            return discount.Count == 0 ? View("index", dataContext) : View("index", discount);
        }
    }
}
