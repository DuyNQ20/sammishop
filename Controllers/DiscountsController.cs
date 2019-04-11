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
        public static string DiscountNotify = "";
        public DiscountsController(DataContext context)
        {
            _context = context;
        }
        

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Discounts.ToListAsync());
        }

        [HttpGet("discount-by-money")]
        public async Task<IActionResult> DiscountByMoney()
        {
            return View("Index",await _context.Discounts.Where(x=>x.DiscountCategoryId==1).ToListAsync());
        }

        [HttpGet("discount-by-percent")]
        public async Task<IActionResult> DiscountByPercent()
        {
            return View("Index",await _context.Discounts.Where(x => x.DiscountCategoryId == 2).ToListAsync());
        }


        // GET: ProductCategories/Create
        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            ViewBag.DiscountProductCategoryId = new MultiSelectList(GetListProductCategory(), "Id", "Name");
            ViewBag.DiscountProductId = new MultiSelectList(GetListProduct(), "Id", "Name");
            ViewData["DiscountCategoryId"] = new SelectList(_context.DiscountCategories, "Id", "Decriptions");
            return View();
        }

        [HttpPost, Route("create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DiscountView discountView, int[] DiscountProductCategoryId, int[] DiscountProductId)
        {
            Discount discount = new Discount();
            discount.Map(discountView);
            if (ModelState.IsValid)
            {
                _context.Add(discount);
                await _context.SaveChangesAsync();

                // Thêm Mã giảm giá cho DiscountProductCategory
                _context.AddRange(GetDiscountProductCategory(discount.Id, DiscountProductCategoryId));

                // Thêm Mã giảm giá cho DiscountProduct
                _context.AddRange(GetDiscountProduct(discount.Id, DiscountProductId));

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

            ViewBag.DiscountProductCategoryId = new MultiSelectList(GetListProductCategory(), "Id", "Name", GetListProductCategorySelected(discount.DiscountProductCategories).Select(x=>x.Id).ToArray());
            ViewBag.DiscountProductId = new MultiSelectList(GetListProduct(), "Id", "Name", GetListProductSelected(discount.DiscountProducts).Select(x=>x.Id).ToArray());
            ViewData["DiscountCategoryId"] = new SelectList(_context.DiscountCategories, "Id", "Decriptions", discount.DiscountCategoryId);
            return View(discount);
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



        /// <summary>
        /// Các hàm hỗ trợ để sử dụng
        /// </summary>
        /// <returns></returns>
        public List<ProductCategory> GetListProductCategory()
        {
            // Thêm list Selected để view multiSelect ProductCategory
            var listProductCategory = new List<ProductCategory>();
            listProductCategory.Add(new ProductCategory() { Name = "Chọn danh mục áp dụng" });
            listProductCategory.AddRange(_context.ProductCategorys.ToList());
            return listProductCategory;
        }

        public List<ProductCategory> GetListProductCategorySelected(List<DiscountProductCategory> discountProductCategories)
        {
            var ProductCategorySelected = new List<ProductCategory>();
            foreach (var item in discountProductCategories)
            {
                ProductCategorySelected.Add(_context.ProductCategorys.Find(item.ProductCategoryId));
            }
            return ProductCategorySelected;
        }

        public List<Product> GetListProduct()
        {
            // Thêm list Selected để view multiSelect Product
            var listProduct = new List<Product>();
            listProduct.Add(new Product() { Name = "Chọn sản phẩm áp dụng" });
            listProduct.AddRange(_context.Products.ToList());
            return listProduct;
        }

        public List<Product> GetListProductSelected(List<DiscountProduct> discountProducts)
        {
            // Thêm list Selected để view multiSelect Product
            var ProductSelected = new List<Product>();
            foreach (var item in discountProducts)
            {
                ProductSelected.Add(_context.Products.Find(item.ProductId));
            }
            return ProductSelected;
        }

        // Hỗ trợ update các tham chiếu many-to-many ở mục áp dụng với danh mục sp hoặc sp
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
        
    }
}
