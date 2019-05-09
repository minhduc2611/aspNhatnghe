using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStoreTemplatev21.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EStoreTemplatev21.Controllers
{
    public class CartController : Controller
    {
        public List<CartItem> Cart => HttpContext.Session.Get<List<CartItem>>("GioHang");
        public IActionResult AddToCart(int id)
        {
            //kiếm trong session đã có hàng hóa có mã id?
            List<CartItem> gioHang = Cart;
            if (gioHang == null)
                gioHang = new List<CartItem>();

            //xử lý
            CartItem item = gioHang.SingleOrDefault(p => p.HangMua.MaHh == id);
            if (item != null)//đã có
            {
                item.SoLuong++;
            }
            else
            {
                //dựa vào id vào CSDL đọc lấy hàng hóa ra
                Random rd = new Random();
                item = new CartItem
                {
                    HangMua = new HangHoa
                    {
                        MaHh = id,
                        DonGia = rd.Next(100, 1000),
                        TenHh = $"Samsung S{rd.Next(10, 19)}"
                    },
                    SoLuong = 1
                };

                gioHang.Add(item);
            }
            //lưu session
            HttpContext.Session.Set("GioHang", gioHang);

            //trả về Json
            return Json(new {
                TongSoLuong = gioHang.Sum(p => p.SoLuong),
                TongTien = gioHang.Sum(p => p.ThanhTien)
            });
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}