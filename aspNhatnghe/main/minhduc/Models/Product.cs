using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace minhduc.Models
{
    public class Product
    {
        [Display(Name = "Ma sp")]
        public int ID { set; get; }

        [Display(Name ="Ten sp")]
        public string Name { set; get; }

        [Display(Name = "GIa sp")]
        public double Price { set; get; }
        [Display(Name = "GIam gia sp")]
        public double Sale { set; get; }

    }
}
