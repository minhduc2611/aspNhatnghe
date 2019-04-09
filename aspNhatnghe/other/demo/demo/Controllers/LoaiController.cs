using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class LoaiController : Controller
    {
        LoaiDataAccessLayer db = new LoaiDataAccessLayer();
        public IActionResult Index()
        {
            return View(db.ToList());
        }
        public IActionResult Create()
        {
            return View();


        }

        [HttpPost]
        public IActionResult Create(Loai lo, IFormFile fHinh)
        {
            //hinh
            if (fHinh != null) {
                string fullpath = Path.Combine(Directory.GetCurrentDirectory(), "root", "Hinh", "Loai", fHinh.FileName);
                    using (var f = new FileStream(fullpath, FileMode.Create)) {
                    fHinh.CopyTo(f);
                    lo.Hinh = fHinh.FileName;
                }
            }

            int MaLoai = db.AddLoai(lo);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            Loai lo = db.GetLoai(id);
            if (lo != null)
            {
                return View(lo);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(int? id,Loai lo)
        {
            db.UpdateLoai(lo);

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            db.DeleteLoai(id);
            return RedirectToAction("Index");
        }

        

    }
}