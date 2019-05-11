using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EStoreTemplatev21.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace EStoreTemplatev21.Controllers
{
    public class DemoController : Controller
    {
            private readonly MyeStoreContext _ctx;
        public DemoController(MyeStoreContext context) {
            this._ctx = context;
        }
        public IActionResult Export()
        {

            // chuan bi du lieu xuat
            var data = _ctx.Loai.ToList();
            var stream = new MemoryStream();

            //new moi 1 excel 
            using (var package = new ExcelPackage(stream)) {
                var sheet = package.Workbook.Worksheets.Add("Loai");

                sheet.Cells.LoadFromCollection(data,true);
                sheet.Cells[1, 1].Value = "Ma Loai";
                sheet.Cells[1, 2].Value = "Ten Loai";
                package.Save();


            }

            stream.Position = 0;
                string FileName = $"Loai_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.xlsx";
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", FileName);
        }
        public IActionResult ImportLoai()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ImportLoai(IFormFile fImport)
        {
            if (fImport == null || fImport.Length <= 0)
            {
                ViewBag.ThongBao = "file k ton tai";
                return View();

            }

            List<Loai> loaiImports = new List<Loai>();

            // tao 1 stream de giu file uplaod len 

            using (var stream = new MemoryStream())
            { // cau hoi : strean la gi !!!!
                fImport.CopyTo(stream);

                //map stream do voi excel file
                using (var package = new ExcelPackage(stream))
                {
                    var sheet = package.Workbook.Worksheets[0];
                    int rowCount = sheet.Dimension.Rows;
                    // duyet qua tung dong cua sheet excel, boc tach du lieu ra

                    for (int i = 2; i <= rowCount; i++)
                    {
                        loaiImports.Add(new Loai
                        {
                            MaLoai = int.Parse(sheet.Cells[i, 1].Value.ToString()),
                            TenLoai = sheet.Cells[i, 2].Value.ToString(),
                            MoTa = sheet.Cells[i, 3].Value.ToString(),
                            Hinh = sheet.Cells[i, 4].Value.ToString()
                        });

                    }
                }

                if (loaiImports.Count > 0)
                {
                    // tat tu tang 
                    _ctx.Database.OpenConnection();
                    _ctx.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Loai OFF");
                    _ctx.SaveChanges();

                    // tien hanh update hoac insert

                    foreach (Loai lo in loaiImports)
                    {
                        Loai item = _ctx.Loai.SingleOrDefault(p => p.MaLoai == lo.MaLoai);
                        if (item != null) // da co -> upadte
                        {
                            item.TenLoai = lo.TenLoai;
                            item.MoTa = lo.MoTa;
                            item.Hinh = lo.Hinh;
                        }
                        else
                        { // k co thi add new lo
                            _ctx.Add(lo);
                        }

                    }

                    // bat tu tang 

                    _ctx.Loai.FromSql("SET IDENTITY_INSERT dbo.Loai ON");
                    _ctx.SaveChanges();

                }
                return View();
            }
        }


    }
}