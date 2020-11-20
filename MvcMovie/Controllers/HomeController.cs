using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalView()
        {
            string[] dayinNov = new string[] { "day-out", "day-out", "day-out", "day-out", "day-out", "day-out", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in" };
            string[]resultNov = new string[] { "true", "false", "true", "false", "true", "false", "true", "false", "true", "false", "true", "false","true", "false", "true", "false" };

            ViewBag.dayNov = dayinNov;
            ViewBag.resNov = resultNov;

            string[] dayinDec = new string[] { "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in", "day-in" };
            string[] resultDec = new string[] { "true", "false", "true", "false", "true", "false", "true", "false" };

            ViewBag.dayDec = dayinDec;
            ViewBag.resDec = resultDec;

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
