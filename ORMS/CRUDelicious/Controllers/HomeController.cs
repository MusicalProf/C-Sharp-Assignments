using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using CRUDelicious.Context;

namespace CRUDelicious.Controllers
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
            ViewBag.AllDishes = _context.Dishes.OrderBy(recent => recent.CreatedAt).ToList();
            return View();
        }

        [Route("AddDish")]
        public IActionResult AddDish()
        {
            return View();
        }

        [Route("AddMethod")]
        public IActionResult AddMethod(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("AddDish");
            }
        }

        [Route("ViewDish/{DishID}")]
        public IActionResult ViewDish(int DishID)
        {
            Dish ThisDish = _context.Dishes.FirstOrDefault(d => d.DishID == DishID);
            return View(ThisDish);
        }

        [Route("EditDish/{DishID}")]
        public IActionResult EditDish(int DishID)
        {
            Dish ThisDish = _context.Dishes.FirstOrDefault(d => d.DishID == DishID);
            return View(ThisDish);
        }

        [Route("EditMethod/{DishID}")]
        public IActionResult EditMethod(Dish UpdatedDish, int DishID)
        {
            Dish ThisDish = _context.Dishes.FirstOrDefault(d => d.DishID == DishID);
            if (ModelState.IsValid)
            {
                ThisDish.Chef = UpdatedDish.Chef;
                ThisDish.Name = UpdatedDish.Name;
                ThisDish.Calories = UpdatedDish.Calories;
                ThisDish.Tastiness = UpdatedDish.Tastiness;
                ThisDish.Description = UpdatedDish.Description;
                ThisDish.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("ViewDish", UpdatedDish);
            }
            else
            {
                return View("EditDish", UpdatedDish);
            }
        }

        [Route("DeleteMethod/{DishID}")]
        public IActionResult DeleteMethod(int DishID)
        {
            Dish ThisDish = _context.Dishes.FirstOrDefault(d => d.DishID == DishID);
            _context.Dishes.Remove(ThisDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
