using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class MyTools
    {
        public static string Upload(IFormFile fHinh, string ToFolder ) {
            string FileName = "";
            if (fHinh != null)
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", ToFolder, fHinh.FileName);
                using (var file = new FileStream(fullPath, FileMode.Create))
                {
                    fHinh.CopyTo(file);
                     FileName = fHinh.FileName;
                }
            }
            return FileName ;
        }
    }
}
