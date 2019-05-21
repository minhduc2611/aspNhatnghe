using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project.Models
{
    public class MyTools
    {
        public static string ConvertToUrlFriendly(string name) {
            string result = name.ToLower().Trim();
            result  = Regex.Replace(result,@"[^a-z0-9\s-]","");
            result  = Regex.Replace(result,@"[\s]+","-");
            result = Regex.Replace(result,@"\s","-"); // /s la khoang trang
            return result;
        }
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
