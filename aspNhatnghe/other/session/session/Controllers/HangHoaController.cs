using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using session.Models;

namespace session.Controllers
{
    public class HangHoaController : Controller
    {
        public IActionResult Index(){
            Random rd = new Random();
            int TongSoHangHoaRandom = rd.Next(100); 

            List<HangHoa> DsHangHoa = new List<HangHoa>();

            for(int i = 0;i < TongSoHangHoaRandom; i++){
                DsHangHoa.Add(new HangHoa{
                    HangHoaId = rd.Next(),
                    TenHangHoa = $"hang hoa so {Guid.NewGuid()}",
                    DonGia = rd.Next(100,1000)
                });
            };
            return View(DsHangHoa);
        }
        
    }
}