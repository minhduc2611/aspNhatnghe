using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace efcore.Models
{
    public class KhachHang
    {
        [Key]
        [Display(Name = "Ma Khach Hang")]
        [MaxLength(20, ErrorMessage = "Tối đa 20 kí tự")]
        public string MaKH { get; set; }

        [Display(Name = "Ho Ten Khach Hang")]
        [Required]
        [MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
        public string HoTen { get; set; }

        [Display(Name = "So Dien Thoai")]
        [MaxLength(50)]
        public string DienThoai { get; set; }

        [Display(Name = "Email")]
        [MaxLength(150)]
        public string Email { get; set; }
    }
}
