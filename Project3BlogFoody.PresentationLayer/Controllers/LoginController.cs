﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project3BlogFoody.EntityLayer.Concrete;
using Project3BlogFoody.PresentationLayer.Models;
using System.Runtime.CompilerServices;

namespace Project3BlogFoody.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Category");
            }
            else
            {
                return View();
            }
        }
    }
}
