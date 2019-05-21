using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project.Models;
using project.Models.Datamodels;

namespace project.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly MyDbContext _ctx;
        public HangHoaController( MyDbContext db) {
            this._ctx = db;
        }
        public IActionResult Index(int? Loai)
        {
            var dsHangHoa = _ctx.HangHoas.AsQueryable();
            if (Loai.HasValue) {
                dsHangHoa = dsHangHoa.Where(p=>p.MaLoai == Loai.Value).AsQueryable();
            }
            var Data = dsHangHoa.Select(p=> new HangHoaView {

            });
            return View();
        }
    }
}