using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using linqCodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace linqCodeFirst.Controllers
{
    public class LoaiController : Controller
    {
        //resharper
        private MyDbContext ctx;
        public LoaiController(MyDbContext context)
        {
            this.ctx = context;
        }
        public IActionResult Index()
        {
            var dsLoai = ctx.Loai.OrderBy(p => p.TenLoai);
            return View(dsLoai);
        }

        //public IActionResult Edit(int? id) {
        //    Loai lo = new Loai();
        //    if (id.HasValue && id.Value != 0) {
        //        //tim dua vao maloai ==> dung sigle or default
        //        lo = ctx.Loai.SingleOrDefault(p => p.MaLoai == id);
        //    }
        //    return PartialView("_EditLoai",lo);
        //}
         public IActionResult Edit(int? id) {
            Loai lo = new Loai();

            if (!id.HasValue ) {
                ViewBag.NoiDung = "Thong tin ma loai khong hop le";
                return PartialView("_thongbao");
            }
                //tim dua vao maloai ==> dung sigle or default
                lo = ctx.Loai.SingleOrDefault(p => p.MaLoai == id);
            if (lo == null) {
                ViewBag.NoiDung = "Khong tim thay loai theo yeu cau";
                return PartialView("_thongbao");

            }
            return PartialView(lo);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Loai lo, IFormFile fHinh) {
            if (ModelState.IsValid) {

                //xu ly anh
                if (fHinh != null) {
                    string path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","images","Hinh","Loai",fHinh.FileName);
                    using (var f = new FileStream(path, FileMode.Create)) {
                        fHinh.CopyTo(f);
                        lo.Hinh = fHinh.FileName;
                    }
                }

                ctx.Update(lo);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }




        

        public IActionResult Delete(int? id)
        {
            Loai lo = new Loai();

            if (id.HasValue)
            {
                //tim dua vao maloai ==> dung sigle or default
                lo = ctx.Loai.SingleOrDefault(p => p.MaLoai == id);
            }
            if (lo == null) // khong tim thay
            {
                ViewBag.NoiDung = "Khong tim thay loai theo yeu cau";
                return PartialView("_thongbao");

            }
            return PartialView(lo);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            Loai lo = ctx.Loai.SingleOrDefault(p => p.MaLoai == id);
            if (lo != null) {
                ctx.Remove(lo);
                await ctx.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

    }
}