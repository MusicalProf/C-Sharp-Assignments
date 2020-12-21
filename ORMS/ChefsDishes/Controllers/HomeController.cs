using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs
                .Include(a => a.AllDishes)
                .OrderByDescending(b => b.CreatedAt)
                .ToList();
            return View();
        }

        [Route("Dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllDishes = _context.Dishes
                .Include(a => a.Creator)
                .ToList();
            return View();
        }

        [Route("NewChef")]
        public IActionResult NewChef()
        {
            return View();
        }

        [Route("AddChef")]
        public IActionResult AddChef(Chef newChef)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewChef");
            }
        }

        [Route("NewDish")]
        public IActionResult NewDish()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            return View();
        }

        [Route("AddDish")]
        public IActionResult AddDish(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
            {
                ViewBag.AllChefs = _context.Chefs.ToList();
                return View("NewDish");
            }
        }
    }
}
