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

namespace Fiorello.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();
            AppUser appuser = new AppUser
            {
                FullName = register.FulName,
                UserName = register.UserName,
                Email = register.Email,
                IsAdmin=false

            };

            if (!register.Terms)
            {
                ModelState.AddModelError("Terms", "Please check");
                return View();
            }
            IdentityResult identityResult = await _userManager.CreateAsync(appuser, register.Pasword);
            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(appuser,RoleEnum.Member.ToString());
            await _signInManager.SignInAsync(appuser,true);
            
            
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser User = await _userManager.FindByNameAsync(loginVM.UserName);
            if (User.IsAdmin==true)
            {
                ModelState.AddModelError("", "username or pasword incorrect");
                return View();
            }
            if (User == null)
            {
                ModelState.AddModelError("", "UserName or Paswor Incorrect");
                return View();
            }

            Microsoft.AspNetCore.Identity.SignInResult Result = await _signInManager.PasswordSignInAsync(User.UserName, loginVM.Pasword, loginVM.RememberMe, true);

            if (!Result.Succeeded)
            {
                if (Result.IsLockedOut)
                {
                    ModelState.AddModelError("", "your account blocked for 5 minutes");
                    return View();
                }
                ModelState.AddModelError("", "UserName Or Pasword Incorrect");
                return View();
            }


            return RedirectToAction("index", "home");
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        [Authorize(Roles ="Member")]
        public async Task<IActionResult> Edit()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditVM userEditvm = new UserEditVM
            {
                UserName=user.UserName,
                Email=user.Email,
                FullName=user.FullName
            };

          
            return View(userEditvm);
         
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Edit(UserEditVM userEditvm)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
           

            UserEditVM euser = new UserEditVM
            {
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email
            };
            if (user.UserName != userEditvm.UserName && await _userManager.FindByNameAsync(userEditvm.UserName) != null)
            {
                ModelState.AddModelError("", $"{userEditvm.UserName} has alrady taken");
                return View(euser);
            }
            if (string.IsNullOrWhiteSpace(userEditvm.CurrentPasword))
            {
                user.UserName = userEditvm.UserName;
                user.FullName = userEditvm.FullName;
                user.Email = userEditvm.Email;
                await _userManager.UpdateAsync(user);
                await _signInManager.SignInAsync(user, true);
            }
            else
            {
                user.UserName = userEditvm.UserName;

                user.FullName = userEditvm.FullName;
                user.Email = userEditvm.Email;
                IdentityResult identityResult = await _userManager.ChangePasswordAsync(user, userEditvm.CurrentPasword, userEditvm.Pasword);
                if (!identityResult.Succeeded)
                {
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(euser);
                }
              


            }
            //await _signInManager.PasswordSignInAsync(user, userEditvm.Pasword, true, true);

            return RedirectToAction("index", "home");

        }



        public IActionResult Show()
        {
            return Content(User.Identity.Name);
        }

    }
}