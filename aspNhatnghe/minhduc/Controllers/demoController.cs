using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using minhduc.Models;

namespace minhduc.Controllers
{
    public class demoController : Controller // ke thua 
    {
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