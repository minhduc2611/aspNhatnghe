using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Linq.Models
{
    public partial class HangHoa
    {
        public HangHoa()
        {
            BanBe = new HashSet<BanBe>();
            ChiTietHd = new HashSet<ChiTietHd>();
            YeuThich = new HashSet<YeuThich>();
        }

        public int MaHh { get; set; }

        [Display(Name = "Ten Hang Hoa")]
        public string TenHh { get; set; }

        [Display(Name = "Ma Loai")]
        public int MaLoai { get; set; }

        [Display(Name = "Mo Ta Don Vi")]
        public string MoTaDonVi { get; set; }

        [Display(Name = "Don Gia")]
        public double? DonGia { get; set; }

        [Display(Name = "Hinh")]
        public string Hinh { get; set; }

        [Display(Name = "Ngay San Xuat")]
        public DateTime NgaySx { get; set; }

        [Display(Name = "Giam Gia")]
        public double GiamGia { get; set; }

        [Display(Name = "So Lan Xem")]
        public int SoLanXem { get; set; }

        [Display(Name = "Mo ta")]
        public string MoTa { get; set; }

        [Display(Name = "Ma Nha CUng Cap")]
        public string MaNcc { get; set; }


        [Display(Name = "Ma Loai")]
        public Loai MaLoaiNavigation { get; set; }

        [Display(Name = "Ma nha cung cap")]
        public NhaCungCap MaNccNavigation { get; set; }
        public ICollection<BanBe> BanBe { get; set; }
        public ICollection<ChiTietHd> ChiTietHd { get; set; }
        public ICollection<YeuThich> YeuThich { get; set; }
    }
}
