using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Models
{
    public class Loai
    {
        [Display(Name="Ma Loai")]
        public int MaLoai { get; set; }

        [Display(Name = "Ten Loai")]
        [MaxLength(50)]
        public string TenLoai { get; set; }

        [Display(Name = "Mo Ta")]
        public string Hinh  { get; set; }

        [Display(Name = "Hinh")]
        [MaxLength(50)]
        public string MoTa { get; set; }
    }
}
