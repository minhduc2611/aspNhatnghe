using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using session.Models;

namespace session.Controllers
{
    public class KhachHangController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {


            return View();
        }
        public IActionResult Login()
        {
            //HttpContext.Session.SetString("LonginName","minhDUc");

            return View();
        }
        [HttpPost]
        public IActionResult Login(KhachHang KH)
        {

            //Kiểm tra xem mã người dùng có hợp lệ không?
            if (ModelState.IsValid)
            {
                KhachHang kh = new KhachHang
                {
                    ID = KH.ID,
                    Name = KH.Name,
                    MatKhau = KH.MatKhau
                };
            //HttpContext.Session.SetString("LonginName","minhDUc");
                HttpContext.Session.Set<KhachHang>("KhachHang", kh);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Loi = "Sai thông tin đăng nhập";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("KhachHang");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Profile()
        {

            return View();
        }
    }
}