﻿using Back_End.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CityController : Controller
    {
        private readonly AppDbContext _context;

        public CityController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<City> city = _context.Cities.ToList();

            return View(city);
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(City city)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            _context.Cities.Add(city);
            _context.SaveChanges();

            return RedirectToAction("index");
        }


        public IActionResult Edit(int id)
        {
            City city = _context.Cities.FirstOrDefault(x => x.Id == id);

            if (city == null) return NotFound();
            return View(city);
        }

        [HttpPost]
        public IActionResult Edit(City city)
        {
            City ExistCity= _context.Cities.FirstOrDefault(x => x.Id == city.Id);

            if (ExistCity == null) return NotFound();

            ExistCity.Name = city.Name;


            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult DeleteFetch(int id)
        {
            City city = _context.Cities.FirstOrDefault(x => x.Id == id);

            if (city == null) return Json(new { status = 404 });

            try
            {
                _context.Cities.Remove(city);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return Json(new { status = 500 });
            }

            return Json(new { status = 200 });
        }
    }
}
