using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LostInTheWoods.Models;
using LostInTheWoods.Factories;

namespace LostInTheWoods.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory trailfactory;

        public HomeController()
        {
            trailfactory = new TrailFactory();
        }
        public IActionResult Index()
        {
            ViewBag.allTrails = trailfactory.FindAll();
            return View();
        }

        [HttpGet("addtrails")]
        public IActionResult AddTrails()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(Trail newTrail)
        {
            if(ModelState.IsValid)
            {
                trailfactory.AddNewTrail(newTrail);
                return RedirectToAction("Index");
            }
            else{
                return View("AddTrails");
            }
        }

        [HttpGet("trails/{id}")]
        public IActionResult FindOne(int id)
        {
            ViewBag.OneTrail = trailfactory.FindOne(id);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
