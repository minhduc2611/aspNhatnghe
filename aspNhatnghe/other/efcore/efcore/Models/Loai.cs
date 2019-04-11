using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace efcore.Models
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        [Display(Name = "Ma Loai")]
        public int MaLoai { get; set; }

        [Display(Name = "Ten Loai")]
        [Required(ErrorMessage = " this field is reqired ")]
        [MaxLength(50,ErrorMessage =" the maximum lenght is 50 ")]
        public string TenLoai { get; set; }

        [Display(Name = "Mo Ta")]
        public string MoTa { get; set; }

        [Display(Name = "Hinh")]
        [MaxLength(50, ErrorMessage = " the maximum lenght is 50 ")]
        public string Hinh { get; set; }

        public ICollection<HangHoa> HangHoas { get; set; } // mot list cac hang hoa
    }
}
