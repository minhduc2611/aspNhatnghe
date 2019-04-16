using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Linq.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Linq.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly eStore20Context _context;

        public HangHoaController(eStore20Context context)
        {
            _context = context;
        }

        public IActionResult TimKiem(string TenHH, double GiaTu, double GiaDen) {
            //toan tu where cua linq, toan tu lamda
            var dsHangHoa = _context.HangHoa.AsQueryable();
            if (!string.IsNullOrEmpty(TenHH)) {
                dsHangHoa = dsHangHoa.Where(hh => hh.TenHh.Contains(TenHH));

            }
            dsHangHoa = dsHangHoa.Where(hh => hh.DonGia.Value >= GiaTu && hh.DonGia.Value >= GiaDen);
            return View(dsHangHoa.Select(hh => new HangHoaView {
                MaHH = hh.MaHh,
                TenHH = hh.TenHh,
                DonGia = hh.DonGia.Value,
                Hinh = hh.Hinh,
                Loai = hh.MaLoaiNavigation.TenLoai,
                NhaCC = hh.MaNccNavigation.TenCongTy

            }));
        }

        // GET: HangHoa
        public async Task<IActionResult> Index()
        {
            var eStore20Context = _context.HangHoa.Include(h => h.MaLoaiNavigation).Include(h => h.MaNccNavigation);
            return View(await eStore20Context.ToListAsync());
        }

        // GET: HangHoa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoa
                .Include(h => h.MaLoaiNavigation)
                .Include(h => h.MaNccNavigation)
                .FirstOrDefaultAsync(m => m.MaHh == id);
            if (hangHoa == null)
            {
                return NotFound();
            }

            return View(hangHoa);
        }

        // GET: HangHoa/Create
        public IActionResult Create()
        {
            ViewData["MaLoai"] = new SelectList(_context.Loai, "MaLoai", "TenLoai");
            ViewData["MaNcc"] = new SelectList(_context.NhaCungCap, "MaNcc", "MaNcc");
            return View();
        }

        // POST: HangHoa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHh,TenHh,MaLoai,MoTaDonVi,DonGia,Hinh,NgaySx,GiamGia,SoLanXem,MoTa,MaNcc")] HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hangHoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoai"] = new SelectList(_context.Loai, "MaLoai", "TenLoai", hangHoa.MaLoai);
            ViewData["MaNcc"] = new SelectList(_context.NhaCungCap, "MaNcc", "MaNcc", hangHoa.MaNcc);
            return View(hangHoa);
        }
        public async Task<IActionResult> UploadFile(IFormFile myfile)
        {
            if (myfile == null || myfile.Length == 0)
                return Content("file not selected");
            // save file vao thu muc myFile
            //tao duong dan 
            string fullname = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", myfile.FileName);

            using (var file = new FileStream(fullname, FileMode.Create))
            {
                await myfile.CopyToAsync(file); // CopyTo + CopyToAcsync
            }
            return View();
        }

        // GET: HangHoa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoa.FindAsync(id);
            if (hangHoa == null)
            {
                return NotFound();
            }
            ViewData["MaLoai"] = new SelectList(_context.Loai, "MaLoai", "TenLoai", hangHoa.MaLoai);
            ViewData["MaNcc"] = new SelectList(_context.NhaCungCap, "MaNcc", "MaNcc", hangHoa.MaNcc);
            return View(hangHoa);
        }

        // POST: HangHoa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.


        // CO UPLOAD HINH

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaHh,TenHh,MaLoai,MoTaDonVi,DonGia,Hinh,NgaySx,GiamGia,SoLanXem,MoTa,MaNcc")] HangHoa hangHoa, IFormFile fHinh)
        {
            if (id != hangHoa.MaHh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //--------------------------HINH---------------------------------------------------  
                    if (fHinh != null)
                    {
                        string fileName = $"_{DateTime.Now.Ticks}{fHinh.FileName}";
                        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", "HangHoa", fileName);
                        using (var file = new FileStream(path, FileMode.Create))
                        {
                            fHinh.CopyTo(file);
                            // delete file trung 

                            if (hangHoa.Hinh != null) {

                            string oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", "HangHoa", hangHoa.Hinh);
                                if (System.IO.File.Exists(oldFile))
                                {
                                    System.IO.File.Delete(oldFile);
                                }
                            }
                            //cap nhat ten file

                            hangHoa.Hinh = fileName;
                        }
                    }
                    //-----------------------hinhEND-------------------------------------------------
                    _context.Update(hangHoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangHoaExists(hangHoa.MaHh))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoai"] = new SelectList(_context.Loai, "MaLoai", "TenLoai", hangHoa.MaLoai);
            ViewData["MaNcc"] = new SelectList(_context.NhaCungCap, "MaNcc", "MaNcc", hangHoa.MaNcc);
            return View(hangHoa);
        }

        // GET: HangHoa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoa
                .Include(h => h.MaLoaiNavigation)
                .Include(h => h.MaNccNavigation)
                .FirstOrDefaultAsync(m => m.MaHh == id);
            if (hangHoa == null)
            {
                return NotFound();
            }

            return View(hangHoa);
        }

        // POST: HangHoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hangHoa = await _context.HangHoa.FindAsync(id);
            _context.HangHoa.Remove(hangHoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HangHoaExists(int id)
        {
            return _context.HangHoa.Any(e => e.MaHh == id);
        }
    }
}
