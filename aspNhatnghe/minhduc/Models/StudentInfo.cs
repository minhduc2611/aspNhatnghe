using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // display 
using System.Linq;
using System.Threading.Tasks;

namespace minhduc.Models
{
    public class StudentInfo
    {
        [Display(Name = "Mã số")]
        public string Id { get; set; }
        [Display(Name = "Họ tên")]
        public string Name { get; set; }
        [Display(Name = "Điểm")]
        public double Marks { get; set; }
    }
}
