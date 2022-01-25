using Fiorello.Areas.Exstensions;
using Fiorello.DAL;
using Fiorello.Helpers;
using Fiorello.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Areas.Manage.Controllers
{
  
    [Area("Manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }

        public IActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Creat(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            if (slider.ImageFile == null){

                ModelState.AddModelError("ImageFile", "bos ola bilmez");
                return View();
            }
            if (!slider.ImageFile.IsImg())
            {

                ModelState.AddModelError("ImageFile", "sekil file yukle");
                return View();
            }
            if (!slider.ImageFile.IsSizeOkey(2))
            {
                ModelState.AddModelError("ImageFile", "Size boyukdur");
            }
            if (slider.SignatuteImgFile == null)
            {
                ModelState.AddModelError("SignatuteImgFile", "bos ola bilmez");
            }
            if (!slider.SignatuteImgFile.IsImg())
            {
                ModelState.AddModelError("SignatuteImgFile", "sekil file yukle");
            }
            if (!slider.SignatuteImgFile.IsSizeOkey(2))
            {
                ModelState.AddModelError("SignatuteImgFile", "Size boyukdur");
            }
            slider.Img = slider.ImageFile.SaveImg(_env.WebRootPath,"assets/img");
            slider.SignatureImg = slider.SignatuteImgFile.SaveImg(_env.WebRootPath,"assets/img");
            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Slider slider)
        {
            Slider Exsistslider = _context.Sliders.FirstOrDefault(s => s.Id == slider.Id);
            if (slider == null) return NotFound();
            if (!ModelState.IsValid) return View(slider);
            
            if(slider.ImageFile != null && slider.SignatuteImgFile == null)
            {
                
                    if (!slider.ImageFile.IsImg())
                    {

                        ModelState.AddModelError("ImageFile", "sekil file yukle");
                        return View();
                    }
                    if (!slider.ImageFile.IsSizeOkey(2))
                    {
                        ModelState.AddModelError("ImageFile", "Size boyukdur");
                    }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/img", Exsistslider.Img);
             

                Exsistslider.Img = slider.ImageFile.SaveImg(_env.WebRootPath, "assets/img");
                
          
            }

           else if (slider.ImageFile == null && slider.SignatuteImgFile != null)
            {

                if (!slider.SignatuteImgFile.IsImg())
                {

                    ModelState.AddModelError("SignatuteImgFile", "sekil file yukle");
                    return View();
                }
                if (!slider.SignatuteImgFile.IsSizeOkey(2))
                {
                    ModelState.AddModelError("SignatuteImgFile", "Size boyukdur");
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/img", Exsistslider.SignatureImg);
                Exsistslider.SignatureImg = slider.SignatuteImgFile.SaveImg(_env.WebRootPath, "assets/img");


            }

           else if (slider.ImageFile != null && slider.SignatuteImgFile != null)
            {

                if (!slider.ImageFile.IsImg())
                {

                    ModelState.AddModelError("ImageFile", "sekil file yukle");
                    return View();
                }
                if (!slider.ImageFile.IsSizeOkey(2))
                {
                    ModelState.AddModelError("ImageFile", "Size boyukdur");
                }

                if (!slider.SignatuteImgFile.IsImg())
                {

                    ModelState.AddModelError("SignatuteImgFile", "sekil file yukle");
                    return View();
                }
                if (!slider.SignatuteImgFile.IsSizeOkey(2))
                {
                    ModelState.AddModelError("SignatuteImgFile", "Size boyukdur");
                }


                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/img", Exsistslider.SignatureImg);
                Exsistslider.SignatureImg = slider.SignatuteImgFile.SaveImg(_env.WebRootPath, "assets/img");

                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/img", Exsistslider.Img);

                Exsistslider.Img = slider.ImageFile.SaveImg(_env.WebRootPath, "assets/img");
            }

            Exsistslider.Title = slider.Title;
            Exsistslider.Description = slider.Description;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }

        public IActionResult Delete(int id)
        {
            Slider item = _context.Sliders.FirstOrDefault(s => s.Id == id);
            if (item == null) return Json(new {status=404 });
            _context.Remove(item);
            Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/img", item.Img);
            Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/img", item.SignatureImg);
            _context.SaveChanges();
            return Json(new { status = 200 });
        }



    }
}
