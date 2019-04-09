using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demo.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReadConfig()
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("wwwroot/configure.json");
            var config = builder.Build();

            ViewBag.Message = config["Message"];
            ViewBag.Config1 = config["MyConfigs:Config1"];
            ViewBag.Config2 = config["MyConfigs:Config2"];
            ViewBag.Config3 = config["MyConfigs:Config3"];
            ViewBag.ConnectionString = config.GetConnectionString("DefaultConnection");
            return View();
        }












        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
