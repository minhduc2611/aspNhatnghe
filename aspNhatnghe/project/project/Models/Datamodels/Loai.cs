using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models.Datamodels
{
    [Table("Loai")]
    public class Loai
    {
        [Key]

        [Display(Name = "Ma Loai")]
        public int MaLoai { get; set; }

        [Display(Name = "Ten Loai")]
        public string TenLoai { get; set; }

        [Display(Name = "Tên khong dau")]
        [MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
        public string TenKhongDau { get; set; }

        [Display(Name = "Mo TA")]
        public string MoTa { get; set; }

        [Display(Name = "Hinh")]
        public string Hinh { get; set; }

        [Display(Name = "Ma Loai Cha")]
        public int MaLoaiCha { get; set; }
    }
}
