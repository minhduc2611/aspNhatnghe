using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    [Table("DonHang")]
    public class DonHang
    {
        public int Id { get; set; }
        [Display(Name = "Ngay Dat Hang")]
        public DateTime NgayDatHang { get; set; }

        [Display(Name = "Trang Thai Don Hang")]
        public TrangThaiDonHang TrangThaiDonHang { get; set; }
        [Display(Name = "Khach Hang")]
        [MaxLength(20, ErrorMessage = "toi da 20 ki tu ")]
        public int MaKH { get; set; }


    }
    public enum TrangThaiDonHang {
        Moi_Dat_hang = 0,
        Da_Thanh_Toan =1 ,
        Hoa_Tat_Don_Hang = 2,
        Huy_Don_Hang = 3
    }
}
