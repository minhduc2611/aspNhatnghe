using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Linq.Models
{
    public class HangHoaView
    {
        [Key]
        public int MaHH { get; set; }
        public string TenHH { get; set; }
        public double DonGia { get; set; }
        public string Hinh { get; set; }
        public string Loai { get; set; }
        public string NhaCC { get; set; }
    }
}
