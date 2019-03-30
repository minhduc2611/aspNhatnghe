using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using minhduc.Models;

namespace minhduc.Controllers
{
    [Route("demo")]
    public class demoController : Controller // ke thua 
    {
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/phone/{phoneName}")]
        public IActionResult PhoneByName(string phoneName) {
            // Samsung Galaxy S10 Plus https://localhost:44371/phone/Samsung-Galaxy-S10-Plus-8g
            phoneName = phoneName.Replace("-"," ");
            return Content(phoneName);
        }
        [Route("hinh-chu-nhat")]
        public IActionResult hinhChuNhat()
        {
            hinhChuNhat hcn = new hinhChuNhat()
            {
                Dai = 3.5 ,
                Rong = 2.5,

            };
            return Content($"HCN {hcn.Dai}*{hcn.Rong} co S= {hcn.DienTich}, P = {hcn.ChuVi} "); // content tra ve chuoi~
        }
    }
}