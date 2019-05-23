using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {   
        [Key]
        [Display(Name ="Ma Khach Hang")]
        [MaxLength(20,ErrorMessage ="toi da 20 ki tu ")]
        public int MaKH { get; set; }
        [Display(Name = "Ten Khach Hang")]
        [MaxLength(150, ErrorMessage = "toi da 150 ki tu ")]
        [Required]
        public string TenKH { get; set; }
        [Display(Name = "Gioi Tinh")]
        public GioiTinh GioiTinh { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string DiaChi { get; set; }
        public string HieuLuc { get; set; }
    }
    public enum GioiTinh {
        [Description("Nam")]
        Nam =0,
        [Description("Nu")]
        Nu = 1
    }
}
