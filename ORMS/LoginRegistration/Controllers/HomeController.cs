using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginRegistration.Models;
using LoginRegistration.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        private User GetUserFromDB()
        {
            return _context.Users.FirstOrDefault(u => u.UserID == HttpContext.Session.GetInt32("UserID"));
        }

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "That email is already in use. Please enter another email.");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Users.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("UserID", newUser.UserID);
                    return RedirectToAction("Dashboard");
                }
            }
            else
            {
                return View("Index");
            }
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("LoginMethod")]
        public IActionResult LoginMethod(LoginUser thisUser)
        {
            if (ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == thisUser.LEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt. Please check your credentials and try again.");
                    ModelState.AddModelError("LPassword", "Invalid login attempt. Please check your credentials and try again.");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(thisUser, userInDb.Password, thisUser.LPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LEmail", "Invalid login attempt. Please check your credentials and try again.");
                    ModelState.AddModelError("LPassword", "Invalid login attempt. Please check your credentials and try again.");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserID", userInDb.UserID);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Login");
            }
        }

        [Route("dashboard")]
        public IActionResult Dashboard()
        {
            User thisUser = GetUserFromDB();
            if (thisUser == null)
            {
                return RedirectToAction("Logout");
            }
            return View(thisUser);
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}
