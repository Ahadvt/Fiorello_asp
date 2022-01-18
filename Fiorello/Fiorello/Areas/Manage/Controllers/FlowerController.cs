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
        public IActionResult Edit(Product product)
        {
            ViewBag.Discaunt = _context.Discounts.ToList();
            ViewBag.Category = _context.Categories.ToList();
            Product exsistProduct = _context.Products.Include(ep => ep.ProductImgs).Include(ep => ep.ProductCategorys).FirstOrDefault(ep => ep.Id == product.Id);

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

                List<ProductImg> RemovableImgs = _context.ProductImgs.Where(pi =>pi.IsMain==false && !product.ImgIds.Contains(pi.Id)).ToList();

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
                        IsMain=false
                        
                    };

                }

            }
            return View();
        }
    }
}
