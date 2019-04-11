using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efcore.Models
{
    public class MyDbContext : DbContext
    {
        //anh xa tu model Loai & HangHoa

        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        //default constructer ==> buoc pahi co ham onConfiguring

        //da khai bao dang service o class startup
        //thi phai dinh nghia them 
        //ham constructer co tham so kieu DbCOntextOptions
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
