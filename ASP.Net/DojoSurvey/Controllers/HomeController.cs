using System;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        // render page with form
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Survey newSurvey)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("result", newSurvey);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("result")]
        public IActionResult Result(Survey newSurvey)
        {
            return View(newSurvey);
        }
    }
}