using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.Models;
using project.Models.Datamodels;

namespace project.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly MyDbContext _ctx;
        private readonly IMapper _map;
        public HangHoaController(MyDbContext db, IMapper Mapper) {
            this._ctx = db;
            this._map = Mapper;
        }

        [Route("{loai}/{hanghoa}")]
        public IActionResult Detail(string loai, string hanghoa) {
            return Content($"{loai}-{hanghoa}");
        }
        public IActionResult Index(int? Loai)
        {
            var dsHangHoa = _ctx.HangHoas
                .Include(prop=>prop.Loai)
                .AsQueryable();
            if(Loai.HasValue) {
                dsHangHoa = dsHangHoa.Where(p=>p.MaLoai == Loai.Value).AsQueryable();
            }
            // var Data = _map.Map<List<HangHoaView>>(dsHangHoa.ToList());
            var Data = new List<HangHoaView>();
            HangHoaView hhvTemp = null;
            foreach (var hh in dsHangHoa.ToList())
            {
                hhvTemp = _map.Map<HangHoaView>(hh);
                hhvTemp.Loai = hh.Loai.TenLoai;
                Data.Add(hhvTemp);
            }
            return View(Data);
        }
    }
}