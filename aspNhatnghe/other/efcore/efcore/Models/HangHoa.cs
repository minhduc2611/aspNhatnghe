using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace efcore.Models
{
    public class HangHoa
    {
        [Key]
        public int MaHH { get; set; }

        [Display(Name = "Ten Hang Hoa ")]
        [Required]
        [MaxLength(50, ErrorMessage = " the maximum lenght is 50 ")]
        public string TenHH { get; set; }

        [Display(Name = "Don gia")]
        public double? DonGia { get; set; } // cho phep de trong !

        [Display(Name = "So Luong")]
        public int? SoLuong { get; set; }

        [Display(Name = "Hinh ")]
        [MaxLength(50, ErrorMessage = " the maximum lenght is 50 ")]
        public string Hinh { get; set; }

        [Display(Name = "Ma Loai")]
        public int MaLoai { get; set; }

        // dinh nghia khoa ngoai
        [Display(Name = "Ten Loai")]
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; } // tao moi quan he ,de generate database



     }
}
