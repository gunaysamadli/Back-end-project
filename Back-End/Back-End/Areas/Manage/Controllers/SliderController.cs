﻿using Back_End.Helpers;
using Back_End.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.Areas.Manage.Controllers
{
    [Area("manage")]

    public class SliderController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Slider slider)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (slider.ImageFile != null)
            {

                if (slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size can not be more than 2MB!");
                    return View();
                }

                string newFileName = FileManager.Save(_env.WebRootPath, "uploads/slider", slider.ImageFile); ;
                slider.Image = newFileName;
            }

            _context.Sliders.Add(slider);
            _context.SaveChanges();


            return RedirectToAction("index");
        }


        public IActionResult Edit(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        public IActionResult Edit(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

            if (existSlider == null) return NotFound();

            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/png" && slider.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "File size can not be more than 2MB!");
                    return View();
                }
                if (existSlider.Image != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/slider", existSlider.Image);
                }

                string newFileName = FileManager.Save(_env.WebRootPath, "uploads/slider", slider.ImageFile);
                existSlider.Image = newFileName;

               
            }

            existSlider.Icon = slider.Icon;
            existSlider.IconTitle = slider.IconTitle;
            existSlider.Title1 = slider.Title1;
            existSlider.Title2 = slider.Title2;
            existSlider.Subtitle = slider.Subtitle;
            existSlider.RedirectUrlText = slider.RedirectUrlText;
            existSlider.RedirectUrl = slider.RedirectUrl;
            existSlider.Order = slider.Order;

            _context.SaveChanges();
            return RedirectToAction("index");
        }


        public IActionResult DeleteFetch(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null) return Json(new { status = 404 });

            try
            {
                _context.Sliders.Remove(slider);
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
