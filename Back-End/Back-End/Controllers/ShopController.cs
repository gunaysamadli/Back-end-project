﻿using Back_End.Model;
using Back_End.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;


        public ShopController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index(int page=1, string search = null, int? categoryId = null, int? statusId = null, int? cityId = null)
        {
            var query = _context.Products.AsQueryable();
            ViewBag.CurrentCategoryId = categoryId;
            ViewBag.CurrentStatusId = statusId;
            ViewBag.CurrentSearch = search;
            ViewBag.CurrentCityId = cityId;

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(x => x.Name.Contains(search));

            if (categoryId != null)
                query = query.Where(x => x.CategoryId == categoryId);


            if (statusId != null)
                query = query.Where(x => x.StatusId == statusId);

            if (cityId != null)
                query = query.Where(x => x.CityId == cityId);

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(x => x.Name.Contains(search));
            }

            string strPr = HttpContext.Request.Cookies["Product"];
            ViewBag.Favorites = null;
            if (strPr != null)
            {
                ViewBag.Favorites = JsonConvert.DeserializeObject<List<FavItemViewModel>>(strPr);

            }
            ShopViewModel shopVM = new ShopViewModel
            {
                Products = query.Where(x=>x.IsSold==false).Include(x => x.ProductImages).
                Include(x => x.Status).Include(x => x.City).Include(x => x.Team).Skip((page - 1) * 4).Take(4).ToList(),
                Statuses = _context.Statuses.ToList(),
                Categories = _context.Categories.Include(x=>x.Products).ToList(),
                Cities = _context.Cities.Include(x => x.Products).ToList()

            };
            ViewBag.TotalPage = Math.Ceiling(query.Count() / 4m);
            ViewBag.SelectedPage = page;
            return View(shopVM);
        }


        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Review(int id,Review review)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);

                Review newReview = new Review
                {
                    Email = review.Email,
                    Username = review.Username,
                    Rate = review.Rate,
                    Date = DateTime.UtcNow,
                    Text = review.Text,
                    ProductId = id,
                    Accept=false,
                    AppUserId = (await _userManager.FindByNameAsync(User.Identity.Name)).Id

                };
                _context.Reviews.Add(newReview);
                _context.SaveChanges();


            return Redirect(HttpContext.Request.Headers["Referer"].ToString());
        }
    }
}
