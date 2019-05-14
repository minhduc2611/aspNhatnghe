using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models.Datamodels
{
    public class MyDbContext : DbContext
    {
        public DbSet<Loai> Loais { set; get; }
        public MyDbContext(DbContextOptions options) : base(options) { }
    }
}
