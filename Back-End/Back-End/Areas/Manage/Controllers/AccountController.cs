﻿using Back_End.Areas.Manage.ViewModels;
using Back_End.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {

            return Ok(new
            {
                UserName = User.Identity.Name,
                IsLogged = User.Identity.IsAuthenticated
            });

            //AppUser admin = new AppUser
            //{
            //    UserName = "SuperAdmin",
            //    FullName = "Super Admin"
            //};

            //var result = await _userManager.CreateAsync(admin, "Admin123");

            //List<string> error = new List<string>();

            //if (!result.Succeeded)
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        error.Add(item.Description);
            //    }
            //    return Ok(error);
            //}

            //IdentityRole role1 = new IdentityRole("SuperAdmin");
            //await _roleManager.CreateAsync(role1);
            //IdentityRole role2 = new IdentityRole("Admin");
            //await _roleManager.CreateAsync(role2);
            //IdentityRole role3 = new IdentityRole("Member");
            //await _roleManager.CreateAsync(role3);


            //AppUser admin = await _userManager.FindByNameAsync("SuperAdmin");
            //await _userManager.AddToRoleAsync(admin, "SuperAdmin");

            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser admin = _userManager.Users.FirstOrDefault(x => x.UserName == loginVM.UserName && x.IsAdmin == true);

            if (admin == null)
            {
                ModelState.AddModelError("", "istifadeci adi ve ya sifre yanlisdir!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(admin, loginVM.Password, loginVM.IsPersistent, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "istifadeci adi ve ya sifre yanlisdir!");
                return View();
            }

            return RedirectToAction("index", "dashboard");
        }

    }
}