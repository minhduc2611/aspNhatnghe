using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(EmployeeInfo EmInfo)
        {
            if (ModelState.IsValid)
                ModelState.AddModelError("loi", "khong hop le");
            return View();
        }
    }
}