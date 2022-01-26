using Fiorello.DAL;
using Fiorello.Enum;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class FlowerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public FlowerController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }



        public IActionResult Index(int page = 1)
        {
            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Products.Count() / 2);

            HomeVM homeVM = new HomeVM
            {
                productCategories = _context.ProductCategories.Include(c => c.Category).Include(p => p.Product).ThenInclude(i => i.ProductImgs).Include(b => b.Product.Discaunt).Skip((page - 1) * 2).Take(2).ToList()
            };
            return View(homeVM);


        }
        public IActionResult Details(int id, int categoryID)
        {

            Product product = _context.Products.Include(p => p.ProductCategorys).ThenInclude(px => px.Category).Include(p => p.ProductImgs).Include(p => p.Discaunt).FirstOrDefault(p => p.Id == id);

            HomeVM homevm = new HomeVM
            {
                productCategories = _context.ProductCategories.Include(p => p.Category).Include(p => p.Product).ThenInclude(p => p.ProductImgs).Include(p => p.Product.Discaunt).Where(b => b.CategoryId == categoryID).Take(2).ToList()
            };
            ViewBag.Product = homevm;


            return View(product);
        }
        //List<Product> products;
        public async Task<IActionResult> AddToCard(int id)
        {
            Product product = _context.Products.FirstOrDefault(p => p.Id == id);
            string basket = HttpContext.Request.Cookies["Basket"];

            if (User.Identity.IsAuthenticated && User.IsInRole(RoleEnum.Member.ToString()))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                BasketItem basketItem = _context.basketItems.FirstOrDefault(b => b.ProductId == id && b.AppUserId==user.Id);

                if (basketItem == null)
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        ProductId = product.Id,
                        Count = 1
                    };
                    _context.Add(basketItem);
                }
                else
                {
                    basketItem.Count++;
                }
                _context.SaveChanges();
            }
            else
            {
                if (basket == null)
                {
                    List<BasketCookieItem> basketCookie = new List<BasketCookieItem>();
                    basketCookie.Add(new BasketCookieItem
                    {
                        Id = product.Id,
                        Count = 1
                    });

                    string basketstr = JsonConvert.SerializeObject(basketCookie);
                    HttpContext.Response.Cookies.Append("Basket", basketstr);
                }
                else
                {
                    List<BasketCookieItem> basketCookie = JsonConvert.DeserializeObject<List<BasketCookieItem>>(basket);

                    BasketCookieItem basketCookie1 = basketCookie.FirstOrDefault(b => b.Id == product.Id);
                    if (basketCookie1 == null)
                    {
                        basketCookie1 = new BasketCookieItem
                        {
                            Id = product.Id,
                            Count = 1
                        };
                        basketCookie.Add(basketCookie1);

                    }
                    else
                    {
                        basketCookie1.Count++;

                    }
                    string basketstr = JsonConvert.SerializeObject(basketCookie);
                    HttpContext.Response.Cookies.Append("Basket", basketstr);

                }
            }

           

            return RedirectToAction("Index", "Home");



        }

        public IActionResult ShowBasket()
        {
            string basketstr = HttpContext.Request.Cookies["Basket"];
            if (!string.IsNullOrEmpty(basketstr))
            {
                List<BasketCookieItem> basketCookies = JsonConvert.DeserializeObject<List<BasketCookieItem>>(basketstr);
                return Json(basketCookies);
            }
            return Content("basket is empty");
        }

        public IActionResult Search(string Name)
        {
            List<Product> products = _context.Products.Where(p=>p.Name.ToLower().Contains(Name.ToLower())).Include(p => p.ProductImgs).Include(p => p.Discaunt).Include(p=>p.ProductCategorys).ThenInclude(pc=>pc.Category).ToList();
           
            
            return View(products);
        }
    }
}
