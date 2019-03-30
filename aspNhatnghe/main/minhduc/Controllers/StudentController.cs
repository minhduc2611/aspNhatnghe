using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using minhduc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace minhduc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Manage(StudentInfo sv)
        {
            //ghi xuống file data.json nằm trong thư mục wwwroot
            string filename = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data.json");

            //ghi xuống file dạng chuỗi JSON
            string jsondata = JsonConvert.SerializeObject(sv);
            System.IO.File.WriteAllText(filename, jsondata);
            return View("Index", sv);
        }

        public IActionResult ReadData()
        {
            string filename = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data.json");
            if(!System.IO.File.Exists(filename))
            {
                return RedirectToAction("Index");
            }
            //đọc chuỗi json từ file
            string jsondata = System.IO.File.ReadAllText(filename);
            StudentInfo sv = JsonConvert.DeserializeObject<StudentInfo>(jsondata);
            return View("Index", sv);
        }
    }
}