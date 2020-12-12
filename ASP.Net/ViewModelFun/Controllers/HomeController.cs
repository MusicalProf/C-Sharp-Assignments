using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            string message = "Hello World! This is the first message of many messages on this page. Enjoy!";
            return View((object)message);
        }

        public IActionResult Numbers()
        {
            int[] numbers = new int[]{
                2, 4, 8, 16, 32, 64, 128
            };
            return View(numbers);
        }

        // [HttpGet("numbers")]
        public IActionResult Users()
        {
            List<User> Users = new List<User>()
            {
                new User{FirstName = "Ra'mar", LastName = "Leach"},
                new User{FirstName = "Robin", LastName = "Nickson"},
                new User{FirstName = "Anthnoy", LastName = "Wright Jr."},
                new User{FirstName = "Anonymous", LastName = "Wilson"},
                new User{FirstName = "MusicalProf", LastName = "Productions"}
            };
            return View(Users);
        }

        public IActionResult User()
        {
            User CheeseIt = new User()
            {
                FirstName = "Cheddar",
                LastName = "Cheese"
            };
            return View(CheeseIt);
        }
    }
}
