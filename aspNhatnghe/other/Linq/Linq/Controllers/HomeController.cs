using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Linq.Models;
using Microsoft.EntityFrameworkCore;

namespace Linq.Controllers
{
    public class HomeController : Controller
    {
        eStore20Context ctx;
        public HomeController(eStore20Context db)
        {
            ctx = db;
        }

        public IActionResult Index()
        {
            // lay top 5 giam gia ---- By LINQ -----
            var top5GiamGia = ctx.HangHoa.OrderByDescending(p => p.GiamGia).Take(5); // lay 5 phan tu dau tien
            ViewBag.Top5GiamGia = top5GiamGia;

            //ef core co the goi srtore procedure/ --- BY SQL--- ===> lay ngau nhien 

            //  SELECT TOP 10 hh.*
            //FROM HangHoa hh
            //ORDER BY NEWID()

            var top10NgauNhien = ctx.HangHoa.FromSql("SELECT TOP 10 hh.* FROM HangHoa hh ORDER BY NEWID()");
            ViewBag.Top10NgauNhien = top10NgauNhien;
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
