using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace minhduc.Controllers
{
    public class CaculatorController : Controller
    {
        public IActionResult caculate(double a,char pt, double b)
        {
            double KetQua = 0;
            switch (pt)
            {
                case '+':
                    KetQua = a + b;
                    break;
                case '-':
                    KetQua = a - b;
                    break;
                case 'x':
                    KetQua = a * b;
                    break;
                case ':':
                    KetQua = a / b;
                    break;
            }
            //viewbag
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.KetQua = KetQua;
            return View("Index");

            //return Content($" {a} {pt} {b} = {KetQua} ");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}