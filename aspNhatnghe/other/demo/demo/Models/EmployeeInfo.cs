using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Models
{
    public class EmployeeInfo
    {
        public enum Gender {nam, nu }

        [Display(Name="Ho Va Ten")]
        [Required(ErrorMessage =" this field is required ! ")]
        [StringLength(10,ErrorMessage =" Ten dai qua !")]
        [MinLength(3,ErrorMessage ="Ten Ngan Qua !")]
        public string FullName { get; set; }

        [Display(Name = "Tuoi")]
        [Range(18, 60, ErrorMessage = "Tuổi phải từ 18 đến 60 !")]
        public int Age { get; set; }


        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Website")]
        [Url]
        public string Website { get; set; }
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Giới tính")]
        public Gender Gen { get; set; }
        [Display(Name = "Lương")]
        [Range(0, 10000000)]
        public double Salary { get; set; }
        [Display(Name = "Bán thời gian")]
        public bool IsPartTime { get; set; }
        [Display(Name = "Địa chỉ")]
        [RegularExpression("[a-zA-Z 0-9]*")]
        public string Address { get; set; }

        [Display(Name = "Điện thoại")]
        [RegularExpression("0[3789][0-9]{8}")]
        public string Phone { get; set; }
    }
}
