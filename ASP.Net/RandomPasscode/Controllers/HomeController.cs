using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Random rand = new Random();
            var Characters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890!@#$%^&*()";
            string Password = "";
            if (HttpContext.Session.GetInt32("Counter") == null)
            {
                HttpContext.Session.SetInt32("Counter", 0);
            }
            ViewBag.Count = HttpContext.Session.GetInt32("Counter");
            int? Count = HttpContext.Session.GetInt32("Counter");
            for (int i = 0; i <= 14; i++)
            {
                Password += Characters[rand.Next(72)];
            }
            HttpContext.Session.SetString("Password", Password);
            ViewBag.Passcode = HttpContext.Session.GetString("Password");
            if(Count >= 0)
            {
                HttpContext.Session.SetInt32("Counter", (int)Count + 1);
                ViewBag.Count = HttpContext.Session.GetInt32("Counter");
            }
            return View();
        }

        [Route("Home/generate")]
        public IActionResult Generate()
        {
            Random rand = new Random();
            var Characters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890!@#$%^&*()";
            string Password = "";
            for (int i = 0; i <= 14; i++)
            {
                Password += Characters[rand.Next(72)];
            }
            HttpContext.Session.SetString("Password", Password);
            ViewBag.Passcode = HttpContext.Session.GetString("Password");
            return RedirectToAction("Index");
        }

        [Route("Home/reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.SetInt32("Counter", 0);
            return RedirectToAction("Index");
        }
    }
}
