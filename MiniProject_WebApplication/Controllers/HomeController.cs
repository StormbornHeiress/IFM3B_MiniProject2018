using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniProject_WebApplication.Models;

namespace MiniProject_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Welcome to the English Premier League!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Have something on your mind? Contact Us @:";

            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "Your application login page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
