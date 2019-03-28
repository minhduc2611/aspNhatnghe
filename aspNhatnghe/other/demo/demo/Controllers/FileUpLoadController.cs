using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class FileUpLoadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> UploadFile(IFormFile myfile)
        {
            if (myfile == null || myfile.Length == 0)
                return Content("file not selected");
            // save file vao thu muc myFile
            //tao duong dan 
            string fullname = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MyFile", myfile.FileName);

            using (var file = new FileStream(fullname,FileMode.Create))
            {
                await myfile.CopyToAsync(file); // CopyTo + CopyToAcsync
            }
            return View();
        }
        public IActionResult UploadFiles(List<IFormFile> myfiles)
        {
            foreach (IFormFile myfile in myfiles) {
                if (myfile == null || myfile.Length == 0)
                    return Content("file not selected");
                // save file vao thu muc myFile
                //tao duong dan 
                string fullname = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MyFile", myfile.FileName);

                using (var file = new FileStream(fullname, FileMode.Create))
                {
                    myfile.CopyTo(file); // CopyTo + CopyToAcsync
                }
            }
            return View();
        }

    }
}