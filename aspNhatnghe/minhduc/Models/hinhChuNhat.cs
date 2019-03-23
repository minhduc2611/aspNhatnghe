using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minhduc.Models
{
    public class hinhChuNhat
    {
        // automatic property
        public double Dai { get; set; }
        public double Rong { get; set; }
        public double DienTich {
            get { return Dai * Rong; }

        }
        public double ChuVi => (Dai + Rong) * 2;
   }
}
