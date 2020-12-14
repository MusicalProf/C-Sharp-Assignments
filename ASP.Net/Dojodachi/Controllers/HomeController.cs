using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Dojodachi.Models;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("Fullness", 20);
            HttpContext.Session.SetInt32("Happiness", 20);
            HttpContext.Session.SetInt32("Meals", 3);
            HttpContext.Session.SetInt32("Energy", 50);
            HttpContext.Session.SetString("Statement", "Start playing!");
            return RedirectToAction("StartGame");
        }

        public IActionResult StartGame()
        {
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Statement = HttpContext.Session.GetString("Statement");
            return View("Index");
        }

        [Route("Feeding")]
        public IActionResult Feeding()
        {
            int? meals = HttpContext.Session.GetInt32("Meals");
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? happiness = HttpContext.Session.GetInt32("Happiness");
            if (meals > 0)
            {
                Random rand = new Random();
                int num = rand.Next(5, 11);
                if (rand.Next(0, 100) <= 25)
                {
                    HttpContext.Session.SetInt32("Meals", (int)meals - 1);
                    HttpContext.Session.SetString("Statement", "Squritle didn't like the meal you gave it. :(");
                    return RedirectToAction("StartGame");
                }
                HttpContext.Session.SetInt32("Meals", (int)meals - 1);
                fullness += num;
                HttpContext.Session.SetInt32("Fullness", (int)fullness);
                HttpContext.Session.SetString("Statement", "That meal was delicious for Squirtle!");
                if (energy >= 100 && happiness >= 100 && fullness >= 100)
                {
                    HttpContext.Session.SetString("Statement", "Squirtle is very happy! YOU WON!!");
                    return RedirectToAction("Restart");
                }
            }
            else
            {
                if (meals <= 0)
                {
                    HttpContext.Session.SetString("Statement", "Squirtle doesn't have anymore meals left. Squirtle needs to go to work.");
                }
            }
            return RedirectToAction("StartGame");
        }

        [Route("Play")]
        public IActionResult Play()
        {
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? happiness = HttpContext.Session.GetInt32("Happiness");
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            if (energy > 0)
            {
                Random rand = new Random();
                int num = rand.Next(5, 11);
                if (rand.Next(0, 100) <= 25)
                {
                    HttpContext.Session.SetInt32("Energy", (int)energy - 5);
                    HttpContext.Session.SetString("Statement", "Squirtle didn't feel like playing. :(");
                    return RedirectToAction("StartGame");
                }
                HttpContext.Session.SetInt32("Energy", (int)energy - 5);
                HttpContext.Session.SetInt32("Happiness", (int)happiness + num);
                HttpContext.Session.SetString("Statement", "Squirtle is happier now after playing games!");
                if (energy >= 100 && happiness >= 100 && fullness >= 100)
                {
                    HttpContext.Session.SetString("Statement", "Squirtle is very happy! YOU WON!!");
                    return RedirectToAction("Restart");
                }
            }
            if (energy <= 0)
            {
                HttpContext.Session.SetString("Statement", "Squirtle doesn't have anymore energy left. Squirtle needs to go to sleep.");
            }
            return RedirectToAction("StartGame");
        }

        [Route("Work")]
        public IActionResult Work()
        {
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? meals = HttpContext.Session.GetInt32("Meals");
            if (energy > 0)
            {
                Random rand = new Random();
                int num = rand.Next(1, 4);
                HttpContext.Session.SetInt32("Energy", (int)energy - 5);
                HttpContext.Session.SetInt32("Meals", (int)meals + num);
                if (num == 1)
                {
                    HttpContext.Session.SetString("Statement", $"Squirtle worked hard and earned {num} meal!");
                }
                else
                {
                    HttpContext.Session.SetString("Statement", $"Squirtle worked hard and earned {num} meals!");
                }
            }
            if (energy <= 0)
            {
                HttpContext.Session.SetString("Statement", "Squirtle doesn't have anymore energy left. Squirtle needs to go to sleep.");
            }
            return RedirectToAction("StartGame");
        }

        [Route("Sleep")]
        public IActionResult Sleep()
        {
            int? energy = HttpContext.Session.GetInt32("Energy");
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            int? happiness = HttpContext.Session.GetInt32("Happiness");

            if (fullness <= 0 || happiness <= 0)
            {
                HttpContext.Session.SetString("Statement", "OH NO! Squirtle died in its sleep! :(");
                return RedirectToAction("Reset");
            }
            else
            {
                if (fullness - 5 <= 0 || happiness - 5 <= 0)
                {
                    HttpContext.Session.SetString("Statement", "OH NO! Squirtle died in its sleep! :(");
                    return RedirectToAction("Reset");
                }
                HttpContext.Session.SetInt32("Energy", (int)energy + 15);
                HttpContext.Session.SetInt32("Happiness", (int)happiness - 5);
                HttpContext.Session.SetInt32("Fullness", (int)fullness - 5);
                HttpContext.Session.SetString("Statement", "Squirtle slept well and is feeling refreshed!");
                return RedirectToAction("StartGame");
            }
        }

        [Route("Restart")] 
        public IActionResult Restart()
        {
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Statement = HttpContext.Session.GetString("Statement");
            return View();
        }

        [Route("Reset")]
        public IActionResult Reset()
        {
            ViewBag.Statement = HttpContext.Session.GetString("Statement");
            return View();
        }

    }
}
