using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User newUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result");
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult Result()
        {
            return View();
        }

    }
}
