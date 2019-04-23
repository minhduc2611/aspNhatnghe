using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace session.Models
{

    // mot dong cau gio hang
    public class CartItem
    {
        public HangHoa HangMua { get; set; }
        public int SoLuong { get; set; }

        public double ThanhTien => SoLuong * HangMua.DonGia;
    }
    //public class CartHelper
    //{
    //    public static List<CartItem> Cart
    //    {
    //        get { }
    //        set { }
    //    }
    //}
}
