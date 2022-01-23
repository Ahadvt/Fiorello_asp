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

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
        [Authorize]
        public async Task<IActionResult> Edit()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditVM EditUser = new UserEditVM
            {
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
            };
            return View(EditUser);
        }



        public IActionResult Show()
        {
            return Content(User.Identity.Name);
        }

    }
}
