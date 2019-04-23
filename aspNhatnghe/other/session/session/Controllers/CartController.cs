using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using session.Models;

namespace session.Controllers
{
    public class CartController : Controller
    {
        public List<CartItem> Cart => HttpContext.Session.Get<List<CartItem>>("GioHang");
        //public List<CartItem> Cart2 {
        //    get {
        //        return  HttpContext.Session.Get<List<CartItem>>("GioHang");
        //    }
        //}

    public IActionResult AddToCart(int id) {
            //kiem trong session  da co hang hoa co ma id
            List<CartItem> GioHang = Cart;
            if (GioHang == null ){
                GioHang = new List<CartItem>(); // gio hang la 1 list
            };
            //xu ly 
            CartItem item = GioHang.SingleOrDefault(p => p.HangMua.HangHoaId == id );

            if (item != null) //da co roi thi them so luong
            {
                item.SoLuong++;
            }
            else {//chua co
                Random rd = new Random();
                
                //them item vao gio neu chuwa co
                item = new CartItem
                {
                    HangMua = new HangHoa()
                    {
                        HangHoaId = id,
                        DonGia = rd.Next(100,1000),
                        TenHangHoa = $"Samsung S {rd.Next(10,19)}"
                    },
                    SoLuong = 1
                };
                GioHang.Add(item);
            }

            //luu session 
            HttpContext.Session.Set<List<CartItem>>("GioHang", GioHang);

            //chuyen den action xem gio hang

            return RedirectToAction("Index", Cart);
        }

        public IActionResult Index()
        {
            return View(Cart);
        }
    }
}