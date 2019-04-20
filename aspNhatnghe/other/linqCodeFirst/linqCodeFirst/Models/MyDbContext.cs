using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqCodeFirst.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Loai> Loai { set; get; }
        public DbSet<HangHoa> HangHoa { set; get; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

            //ham tao nay se lay thong so ket noi CSDL
            // tu service duoc khai bao trong configuratiom service o lop startup
        }
    }
}
