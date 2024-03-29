﻿using Back_End.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.Areas.Manage.Controllers
{
    [Area("manage")]

    public class StatusController : Controller
    {
        private readonly AppDbContext _context;

        public StatusController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Status> statuses = _context.Statuses.ToList();

            return View(statuses);
        }

        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Status status)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            _context.Statuses.Add(status);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Status status = _context.Statuses.FirstOrDefault(x => x.Id == id);

            if (status == null) return NotFound();
            return View(status);
        }

        [HttpPost]
        public IActionResult Edit(Status status)
        {
            Status ExistStatus = _context.Statuses.FirstOrDefault(x => x.Id == status.Id);

            if (ExistStatus == null) return NotFound();

            ExistStatus.Name = status.Name;


            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult DeleteFetch(int id)
        {
            Status status = _context.Statuses.FirstOrDefault(x => x.Id == id);

            if (status == null) return Json(new { status = 404 });

            try
            {
                _context.Statuses.Remove(status);
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
