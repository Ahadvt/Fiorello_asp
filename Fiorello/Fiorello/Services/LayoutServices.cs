using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Services
{
    public class LayoutServices
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _Httpcontext;
        private readonly UserManager<AppUser> _userManager;

        public LayoutServices(AppDbContext context, IHttpContextAccessor httpContext, UserManager<AppUser> userManager)
        {
            _context = context;
            _Httpcontext = httpContext;
            _userManager = userManager;
        }

        public Settings GetSettings()
        {
            Settings data = _context.Settings.FirstOrDefault();
            return data;
        }


        public async Task<BasketVm> ShowBasket()
        {
            string basket = _Httpcontext.HttpContext.Request.Cookies["Basket"];


            BasketVm basketVm = new BasketVm
            {
                TotalPrice = 0,
                Count = 0,
                basketItemVms = new List<BasketItemVm>()

            };
            if (_Httpcontext.HttpContext.User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.FindByNameAsync(_Httpcontext.HttpContext.User.Identity.Name);
                List<BasketItem> BasketItems = _context.basketItems.Where(b => b.AppUserId == appUser.Id).ToList();

                foreach (BasketItem item in BasketItems)
                {
                    Product product = _context.Products.Include(p=>p.Discaunt).FirstOrDefault(p => p.Id == item.ProductId);
                    if (product != null)
                    {
                        BasketItemVm basketItem = new BasketItemVm
                        {
                            Count = item.Count,
                            Product = _context.Products.Include(p => p.ProductImgs).FirstOrDefault(p => p.Id == item.ProductId)

                        };
                        basketItem.Price = basketItem.Product.DiscauntId == null ? basketItem.Product.Price : basketItem.Product.Price * (100 - basketItem.Product.Discaunt.Precenet) / 100;
                        basketVm.Count ++;
                        basketVm.basketItemVms.Add(basketItem);
                        basketVm.TotalPrice = basketItem.Price * basketItem.Count;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(basket))
                {
                    List<BasketCookieItem> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItem>>(basket);

                    foreach (BasketCookieItem item in basketCookieItems)
                    {
                        Product product = _context.Products.FirstOrDefault(p => p.Id == item.Id);
                        if (product != null)
                        {
                            BasketItemVm basketItem = new BasketItemVm
                            {
                                Product = _context.Products.Include(b => b.ProductImgs).Include(b => b.Discaunt).FirstOrDefault(b => b.Id == item.Id),
                                Count = item.Count
                            };

                            basketItem.Price = basketItem.Product.DiscauntId == null ? basketItem.Product.Price : basketItem.Product.Price * (100 - basketItem.Product.Discaunt.Precenet) / 100;
                            basketVm.basketItemVms.Add(basketItem);
                            basketVm.TotalPrice += basketItem.Price * basketItem.Count;
                            basketVm.Count++;
                        }


                    }

                }
            }
            return basketVm;


        }


    }
}
