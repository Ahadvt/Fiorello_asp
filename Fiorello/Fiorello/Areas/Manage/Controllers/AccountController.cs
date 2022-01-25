using Fiorello.Enum;
using Fiorello.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Areas.Manage.Controllers
{





    [Area("Manage")]
    //[Authorize(Roles = "SuperAdmin,Admin")]
    public class AccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInResult;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInResult, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInResult = signInResult;
            _roleManager = roleManager;
        }


        public IActionResult Index()
        {
            List<AppUser> Admins = _userManager.Users.Where(u=>u.IsAdmin==true).ToList();
            ViewBag.Roles = _roleManager.Roles.ToList();

            return View(Admins);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            AppUser user = await _userManager.FindByNameAsync(login.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "username or pasword incorrect");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInResult.PasswordSignInAsync(user, login.Pasword, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or pasword incorrect");
                return View();
            }
            return RedirectToAction("index", "dashboard");
        }

        //public async Task CreateRole()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole(RoleEnum.SuperAdmin.ToString()));
        //    await _roleManager.CreateAsync(new IdentityRole(RoleEnum.Admin.ToString()));
        //    await _roleManager.CreateAsync(new IdentityRole(RoleEnum.Member.ToString()));
        //}


        public IActionResult AdminCreate()
        {
            ViewBag.Roles = _roleManager.Roles.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> AdminCreate(CreateAdminVM createAdminVM)
        {
            if (!ModelState.IsValid) return View();
            AppUser appUser = await _userManager.FindByIdAsync(createAdminVM.UserName);

            ViewBag.Roles = _roleManager.Roles.ToList();


            AppUser user = new AppUser
            {
                UserName = createAdminVM.UserName,
                IsAdmin = true,
                Roles=createAdminVM.Role
            };
            IdentityResult result = await _userManager.CreateAsync(user, createAdminVM.Pasword);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return RedirectToAction("admincreate", "account");
            }

            await _userManager.AddToRoleAsync(user, createAdminVM.Role);
            //return RedirectToAction("index", "home");
            //await _userManager.CreateAsync(user, "ahad123.");

            //await _userManager.AddToRoleAsync(user, RoleEnum.SuperAdmin.ToString());

            //return View();
            return RedirectToAction("index", "account");
        }

        public IActionResult Show()
        {
            return Content(User.Identity.Name);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInResult.SignOutAsync();
            return RedirectToAction("Login", "account");
        }
    }
}
