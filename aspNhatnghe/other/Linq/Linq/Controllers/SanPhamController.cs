using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Linq.Models;
using Microsoft.AspNetCore.Mvc;

namespace Linq.Controllers
{
    public class SanPhamController : Controller
    {
        eStore20Context ctx;
        public SanPhamController(eStore20Context db) {
            ctx = db;
        }

        public IActionResult DanhSach (int? maLoai, string maNcc) {
            var dsSanPham = ctx.HangHoa.AsQueryable();
            if (maLoai.HasValue) {
                dsSanPham = dsSanPham.Where(p => p.MaLoai == maLoai);
                    }
            if (!string.IsNullOrEmpty(maNcc)) {
                dsSanPham = dsSanPham.Where(p => p.MaNcc == maNcc);
            }
            return View(dsSanPham);
        }
    }
}