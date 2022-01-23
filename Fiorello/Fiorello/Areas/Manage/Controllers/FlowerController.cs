using Fiorello.Areas.Exstensions;
using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class FlowerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public FlowerController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.Include(p=>p.ProductImgs).ToList();
            return View(products);
        }
        public IActionResult Creat()
        {
            ViewBag.Discaunt = _context.Discounts.ToList();
            ViewBag.Category = _context.Categories.ToList();
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creat(Product product)
        {
            ViewBag.Discaunt = _context.Discounts.ToList();
            ViewBag.Category = _context.Categories.ToList();
            if (!ModelState.IsValid) return View();

            if (product.DiscauntId == 0)
            {
                product.DiscauntId = null;
            }
            product.ProductCategorys = new List<ProductCategory>();
            product.ProductImgs = new List<ProductImg>();



            foreach (int id in product.CategoryIds)
            {
                ProductCategory productCategory = new ProductCategory
                {
                    Product = product,
                    CategoryId = id
                };
                product.ProductCategorys.Add(productCategory);
            }
            foreach (var img in product.ImageFile)
            {
                if (!img.IsImg())
                {
                    ModelState.AddModelError("ImageFile", "type img olmalidir");
                }
                if (!img.IsSizeOkey(2))
                {
                    ModelState.AddModelError("ImageFile", "type max 2mb ola biler");
                }

            }
            foreach (var img in product.ImageFile)
            {
                ProductImg productImg = new ProductImg
                {
                    Img = img.SaveImg(_env.WebRootPath, "assets/img"),
                    IsMain = product.ProductImgs.Count < 1 ? true : false,
                    Product = product

                };
                product.ProductImgs.Add(productImg);
            }
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Discaunt = _context.Discounts.ToList();
            ViewBag.Category = _context.Categories.ToList();
            Product product = _context.Products.Include(p=>p.ProductCategorys).Include(p=>p.ProductImgs).FirstOrDefault(c => c.Id == id);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            ViewBag.Discaunt = _context.Discounts.ToList();
            ViewBag.Category = _context.Categories.ToList();
            Product exsistProduct = _context.Products.Include(ep => ep.ProductImgs).Include(ep => ep.ProductCategorys).FirstOrDefault(ep => ep.Id == product.Id);

            if (!ModelState.IsValid) return View();
            if (exsistProduct == null) return NotFound();
            if (product.ImageFile != null)
            {
                foreach (var img in product.ImageFile)
                {
                    if (img.IsImg())
                    {
                        ModelState.AddModelError("ImageFile", "please choose img file");
                    }
                    if (!img.IsSizeOkey(2))
                    {
                        ModelState.AddModelError("ImageFile", "type max 2mb ola biler");
                    }
                }

                List<ProductImg> RemovableImgs = _context.ProductImgs.Where(pi => !product.ImgIds.Contains(pi.Id)).ToList();

                exsistProduct.ProductImgs.RemoveAll(pi => RemovableImgs.Any(ri => ri.Id == pi.Id));
                foreach (var img in RemovableImgs)
                {
                    Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/img", img.Img);
                }
                foreach (var item in product.ImageFile)
                {
                    ProductImg productImg = new ProductImg
                    {
                        Img = item.SaveImg(_env.WebRootPath, "assets/img"),
                        IsMain = false,
                        ProductID=product.Id
                       
                    };
                    exsistProduct.ProductImgs.Add(productImg);

                }
                List<ProductCategory> removableCatgory = _context.ProductCategories.Where(pc => product.CategoryIds.Contains(pc.Id)).ToList();
                exsistProduct.ProductCategorys.RemoveAll(pc => removableCatgory.Any(rc => rc.Id == pc.Id));
                foreach (var item in product.CategoryIds)
                {
                    ProductCategory productCategory = _context.ProductCategories.FirstOrDefault(pc => pc.CategoryId == item);

                    ProductCategory pCategory = new ProductCategory
                    {
                        CategoryId = item,
                        ProductId = exsistProduct.Id
                    };
                    exsistProduct.ProductCategorys.Add(pCategory);
                }
                exsistProduct.Deminition = product.Deminition;
                exsistProduct.Description = product.Description;
                exsistProduct.Name = product.Name;
                exsistProduct.Price = product.Price;
                exsistProduct.Skucode = product.Skucode;
                exsistProduct.Weight = product.Weight;
                exsistProduct.Instock = product.Instock;
                if (product.DiscauntId == 0)
                {
                    product.Discaunt = null;
                }
                exsistProduct.Discaunt = product.Discaunt;

                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Delete(int Id)
        {
          Product products = _context.Products.FirstOrDefault(p => p.Id ==Id);
            if (!ModelState.IsValid) return Json(new { status = 404 });
            if (products == null) return Content("yoxdur");

            List<ProductImg> productImgs = _context.ProductImgs.Where(pi=>pi.ProductID==Id).ToList();
            foreach (var item in productImgs)
            {
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/img", item.Img);
            }
            _context.Products.Remove(products);
            _context.SaveChanges();
            return Json(new {status=200 });
        }
    }
}
