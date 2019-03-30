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

        
        public IActionResult employeeManage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult employeeManage(Employee Em)
        {
            // if (ModelState.IsValid)  ModelState.AddModelError("loi", "khong hop le");
            return View();
        }

        public IActionResult CheckEmployeeId(int EmpId)
        {
            if (EmpId == null)
            {
                return Json(true); //hop le
            }

            //doan nay check trong database 
            if (EmpId == 777)
            {
                return Json("ma nay co roi");
            }
            return Json(true);

        }


        // demo 1
        public IActionResult JqueryValidation()
        {
            return View();
        }
        //demo2
        public IActionResult JqueryValidateEmployee()
        {
            return View();
        }
    }
}