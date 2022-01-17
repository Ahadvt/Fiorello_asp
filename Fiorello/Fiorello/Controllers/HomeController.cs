//using Fiorello.Models;
using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
            public HomeController(AppDbContext context)
        {
            _context = context;
        }
           
        public IActionResult Index()
        {
            HomeVM homeVm = new HomeVM()
            {
                sliders = _context.Sliders.ToList(),
                settings = _context.Settings.FirstOrDefault(),
                expertsp=_context.ExpertPositions.Include(b=>b.Expertts).ToList(),
                blogs=_context.Blogs.ToList(),
                carusels=_context.Carusels.ToList(),
                categories=_context.Categories.ToList(),
                productCategories=_context.ProductCategories.Include(c=>c.Category).Include(p=>p.Product).ThenInclude(i=>i.ProductImgs).Include(b=>b.Product.Discaunt).ToList(),
            };
            return View(homeVm);
        }


     
        
    }
}
