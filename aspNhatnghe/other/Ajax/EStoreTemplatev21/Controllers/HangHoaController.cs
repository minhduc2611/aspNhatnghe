using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EStoreTemplatev21.Models;
using Microsoft.AspNetCore.Mvc;

namespace EStoreTemplatev21.Controllers
{
    public class HangHoaController : Controller
    {
        MyeStoreContext ctx;
        public HangHoaController(MyeStoreContext db)
        {
            ctx = db;
        }

        public IActionResult PhanTrang()
        {
            int soTrang = (int)Math.Ceiling(1.0 * ctx.HangHoa.Count() / MyTool.SoHangHoaMoiTrang);
            ViewBag.TongSoTrang = soTrang;
            return View();
        }

        public IActionResult Index()
        {
            int soTrang = (int) Math.Ceiling(1.0 * ctx.HangHoa.Count() / MyTool.SoHangHoaMoiTrang);
            ViewBag.TongSoTrang = soTrang;
            return View();
        }

        public IActionResult Load(int pageNo = 0)
        {
            var dsHangHoa = ctx.HangHoa
                .Skip(pageNo * MyTool.SoHangHoaMoiTrang)
                .Take(MyTool.SoHangHoaMoiTrang)
                .Select(p=> new HangHoaViewModel
                {
                    MaHH = p.MaHh, TenHH = p.TenHh,
                    DonGia = p.DonGia.Value,
                    Hinh = p.Hinh,
                    Loai = p.MaLoaiNavigation.TenLoai
                });

            return PartialView(dsHangHoa);
        }
    }
}