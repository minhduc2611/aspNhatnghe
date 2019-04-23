using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using session.Models;

namespace session.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DemoSession()
        {
             //       gan gia tri cho session
            HttpContext.Session.SetString("Ten","NhatNghe");
            HttpContext.Session.SetInt32("Tuoi",10);

            HangHoa hh = new HangHoa {
                HangHoaId = 1,
                TenHangHoa = "Iphone  X",
                DonGia = 4500000
            };
            HttpContext.Session.Set<HangHoa>("HangHoa", hh);

            return View();
        }

        public IActionResult Demo()
        {
            DateTime Finish = new DateTime(2019,6,10);
            string result = $"con {Finish.TinhKhoangCachNgay(DateTime.Now)} ngay nua thi ket thuc khoa ";

            int N = new Random().Next(1, 20);
            string result2 = $"tong {N} so nguyen lieu dau tien la {N.TongN()}";

            int G = new Random().Next(1, 20);
            return Json(new {
                S1 = result,
                S2 = result2
            } );
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
