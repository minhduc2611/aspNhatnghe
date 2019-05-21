using Microsoft.EntityFrameworkCore;
using project.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project.Models;

namespace project.Models.Datamodels
{
    public class MyDbContext : DbContext
    {
        public DbSet<Loai> Loais { set; get; }
        public DbSet<HangHoa> HangHoas { set; get; }
        public DbSet<QuaTang> QuaTangs { get; set; }
        public DbSet<NhanQua> NhanQuas { get; set; }

        public MyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<project.Models.HangHoaView> HangHoaView { get; set; }
    }
}
