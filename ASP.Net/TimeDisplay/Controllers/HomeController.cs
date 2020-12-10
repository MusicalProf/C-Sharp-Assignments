using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime.ToString("MMM d, yyyy hh:mm:ss tt");
            return View();
        }
        [HttpGet("refresh")]
        public IActionResult Refresh()
        {
            return RedirectToAction("Index");
        }
    }
}