using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechSquad.Models.Models;
using TechSquad.Models.ViewModels;

namespace TechSquad.Application.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
     //   private RoleManager<IdentityRole> _roleManager { get; }
        public LoginController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
         //   _roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginViewModel model)
        {
            ApplicationUser user;
            if (model.Email.Contains("@"))
            {
                 user = await _userManager.FindByEmailAsync(model.Email);
            }
            else
            {
                 user = null;
            }
            if (user == null)
            {
                ModelState.AddModelError("", "Enter Correct Email");
                return View(model);
            }
            var result = await
            _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Enter Correct Password");
                return View(model);
            }

            return RedirectToAction("Index", "Admin");
         
        }
       
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View();

           ApplicationUser user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                ModelState.AddModelError("","Email Already Taken");
                return View();
            }

            ApplicationUser newUser = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Email,
                //Password=model.Password
            };
            IdentityResult result = await _userManager.CreateAsync(newUser, model.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return RedirectToAction("Login");
         
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(SignIn));
        }
    }
}
