using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sammishop.Data;
using Sammishop.Mapper;
using Sammishop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace  Sammishop.Controllers
{
    [Route("admin/products")]
    public class ProductsController : Controller
    {
        private readonly DataContext _context;
        private readonly StorageConfiguration _storageConfiguration;

        public ProductsController(DataContext context, IOptions<StorageConfiguration> storageConfiguration)
        {
            _context = context;
            _storageConfiguration = storageConfiguration.Value;
        }

        public void AddFilesForProduct(List<IFormFile> files, int productId, bool thumbnail = false)
        {
            var list = new List<Models.File>();

            var path = Path.GetFullPath(Path.Combine(_storageConfiguration.StorageDirectory));
            Directory.CreateDirectory(path);

            int[] sizes = { 100, 1000 };

            foreach (var item in files)
            {
                var filePath = Path.Combine(path, item.FileName);

                if (item.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        item.CopyTo(stream);
                        var file = new Models.File();
                        if (thumbnail)
                            file.SaveMap(item, productId, true);
                        else
                            file.SaveMap(item, productId);
                        
                        // Resize ảnh
                        var orignalImage = System.Drawing.Image.FromStream(stream);
                        foreach (var size in sizes)
                        {
                            var bmp = Lib.Lib.ResizeImage(orignalImage, size);

                            var tempBmp = Path.Combine(path, size.ToString());
                            try { Directory.CreateDirectory(tempBmp); } catch { }
                            tempBmp = Path.Combine(tempBmp, item.FileName);
                            bmp.Save(tempBmp);
                        }
                        list.Add(file);
                        stream.Close();
                    }
                }
            }
            _context.AddRange(list);
            _context.SaveChanges();
        }

        public void UpdateFilePathsForProduct(List<IFormFile> files, int productId, bool thumbnai = false)
        {
            var listFile = _context.Files.Where(x => x.ProductId == productId & x.thumbnail == thumbnai).ToList();

            if (files.Count != 0)
            {
                _context.RemoveRange(listFile); // Xóa đi

                AddFilesForProduct(files, productId, thumbnai); // thêm lại
            }
        }

        // GET: Products
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("AdminID") == null)
                return RedirectToAction("AdminLogin", "Admin");

            var dataContext = _context.Products.Include(p => p.Files).Include(x => x.ProductCategory);
            
            return View(await dataContext.ToListAsync());
        }


        // GET: Products/Create
        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategorys, "Id", "Name");
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Name");
            ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name");
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductView productView, List<IFormFile> files, List<IFormFile> file)
        {
            var product = new Models.Product();
            var listFile = new List<Models.File>();
            //var path = System.IO.Path.GetFullPath(System.IO.Path.Combine(StorageConfiguration.StorageDirectory));
            //System.IO.Directory.CreateDirectory(path);
            product.SaveMap(productView);

            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                // Upload file
                AddFilesForProduct(files, product.Id); // Upload image for product
                AddFilesForProduct(file, product.Id, true); // Upload thumbnail for product
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategorys, "Id", "Name");
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Name");
            ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name");
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name");
            return View();

        }

        // GET: Products/Edit/5
        [HttpGet, Route("edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.Include(x => x.Files).FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategorys, "Id", "Name", product.ProductCategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Name", product.SupplierId);
            ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name", product.VendorId);
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name", product.StatusId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductView productView, List<IFormFile> files, List<IFormFile> file)
        {
            // cập nhật ảnh sản phẩm
            UpdateFilePathsForProduct(files, id);

            // Cập nhật thumbail
            UpdateFilePathsForProduct(file, id, true);


            // Cập nhật sản phẩm
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            product.Map(productView);
            _context.Entry(product).State = EntityState.Modified;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet, Route("edit/{id}/Inventory")]
        public async Task<IActionResult> EditInventory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.Include(x => x.Files).FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategorys, "Id", "Name", product.ProductCategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Name", product.SupplierId);
            ViewData["VendorId"] = new SelectList(_context.Vendors, "Id", "Name", product.VendorId);
            ViewData["StatusId"] = new SelectList(_context.Statuses, "Id", "Name", product.StatusId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, Route("edit/{id}/Inventory")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditInventory(int id, int inventory)
        {
            // Cập nhật sản phẩm
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            product.Inventory = inventory;
            _context.Entry(product).State = EntityState.Modified;


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet, Route("update/status/{id}")]
        public async Task<IActionResult> UpdateStatus(int? id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            product.StatusId = product.StatusId == 1 ? 2 : 1;
            product.Active = product.StatusId == 1 ? true : false;

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Products/Delete/5
        [HttpGet, Route("delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //TempData["Erro"] = false;
            var product = await _context.Products.FindAsync(id);
            //try
            //{
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            //}
            //catch(Exception ex)
            //{
            //    TempData["Erro"] = true;
            //}
            
            return RedirectToAction(nameof(Index));
        }




        [HttpGet, Route("search")]
        public async Task<IActionResult> Search([FromQuery]string query)
        {
            // var dataContext = _context.Discounts.ToList();
            // var disounts = new List<Models.Discount>();
            
            // if (!String.IsNullOrEmpty(query))
            // {
            //     foreach (var item in dataContext)
            //     {
            //         if (item.Descriptions.ToLower().Contains(query.ToLower()))
            //         {
            //             disounts.Add(item);
            //         }
            //     }
            // }
            //return disounts.Count == 0 ? View("index", dataContext) : View("index", disounts);

           
            if (HttpContext.Session.GetInt32("AdminID") == null)
                return RedirectToAction("AdminLogin", "Admin");

            var dataContext = _context.Products
            .Include(p => p.Files)
            .Include(x => x.ProductCategory)
            .AsQueryable()
            ;

            if (!String.IsNullOrEmpty(query))
            {
                dataContext = dataContext.Where(x => x.Name.ToUpper().Contains(query.ToUpper()));
            }
            
            return View("Index", await dataContext.ToListAsync());
        }



    }

}
