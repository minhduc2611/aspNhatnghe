using datafirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace datafirst.Components
{
    public class LoaiMenu : ViewComponent
    {
        private readonly MyeStoreContext ctx;

        public LoaiMenu(MyeStoreContext Db)
        {
            ctx = Db;
        }

        public async Task<IViewComponentResult> InvokeAsync() {
            return View(
                ctx.Loai.OrderBy(p => p.TenLoai)
                );
        }
    }
}
