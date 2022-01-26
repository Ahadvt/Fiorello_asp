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

        [Authorize(Roles = "SuperAdmin")]
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

        [Authorize(Roles = "SuperAdmin")]
        public IActionResult AdminCreate()
        {
            ViewBag.Roles = _roleManager.Roles.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "SuperAdmin,Admin")]
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

        public async Task<IActionResult> EditAdmin(string id, EditAdminVm adminvm)
        {
            AppUser Admins = await _userManager.FindByIdAsync(id);
            
            EditAdminVm editAdminVm = new EditAdminVm
            {
                UserName = Admins.UserName,
                Role = Admins.Roles
            };
            ViewBag.Roles = _roleManager.Roles.ToList();
            return View(editAdminVm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("EditAdmin")]

        public async Task<IActionResult> EditAdminPost(string id ,EditAdminVm adminvm)
        {
           
            if (!ModelState.IsValid) return View();
            AppUser admin = await _userManager.FindByIdAsync(id);
            ViewBag.Roles = _roleManager.Roles.ToList();
            EditAdminVm eadmin = new EditAdminVm
            {
                UserName = admin.UserName,
               

            };

            //if (_userManager.FindByNameAsync(adminvm.UserName)==null)
            //{
            //    ModelState.AddModelError("", "this username alrady exsist");
            //    return View(eadmin);

            //}
            if (string.IsNullOrWhiteSpace(adminvm.CurrenPasword))
            {
                admin.UserName = adminvm.UserName;
                admin.Roles = adminvm.Role;
                await _userManager.UpdateAsync(admin);


            }
            else
            {
                admin.UserName = adminvm.UserName;
                admin.Roles = adminvm.Role;

                IdentityResult Result = await _userManager.ChangePasswordAsync(admin, adminvm.CurrenPasword, adminvm.Pasword);
                if (!Result.Succeeded)
                {
                    foreach (var item in Result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);

                    }
                    return View(eadmin);
                }
            }
            //await _signInManager.PasswordSignInAsync(user, userEditvm.Pasword, false, true);

            return RedirectToAction("index", "account");
        }
    }
}
