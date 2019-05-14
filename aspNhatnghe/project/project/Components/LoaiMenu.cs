using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models.Datamodels
{
    public class LoaiMenu : ViewComponent
    {
        private readonly MyDbContext _ctx;
        public LoaiMenu(MyDbContext db) {
            _ctx = db;
        }

        public IViewComponentResult Invoke() {
            var Ds = _ctx.Loais.Where(p => p.MaLoaiCha == 0);
            return View(Ds);
        }
    }
}
