using Fiorello.DAL;
using Fiorello.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index(int page=1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Categories.Count() / 2);
            ViewBag.CurrentPage = page;

           List<Category> categgory = _context.Categories.Include(b => b.ProductCategorys).Skip((page - 1) * 2).Take(2).ToList();
            return View(categgory);
        }

        public IActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Creat(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
            
        }

        public IActionResult Edit(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            Category exsistcatg = _context.Categories.FirstOrDefault(c => c.Id == category.Id);

            if (exsistcatg==null)
            {
                return NotFound();
            }
            Category SameName = _context.Categories.FirstOrDefault(b => b.Name.ToLower().Trim() == category.Name.ToLower().Trim());

            if (SameName!=null)
            {
                ModelState.AddModelError("", "bu ad artiq movcuddur");
                return View();
            }

            exsistcatg.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return Json(new {status=404 });
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return Json(new { status=200});
         

        }
    }
}
