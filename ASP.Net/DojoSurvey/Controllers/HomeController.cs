using System;
using Microsoft.AspNetCore.Mvc;
// using DojoSurvey.Models;

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
        [HttpPost("result")]
        public IActionResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Result");
        }
    }
}