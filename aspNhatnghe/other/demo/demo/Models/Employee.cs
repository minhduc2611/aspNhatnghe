using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Models
{
    public enum Gender { Nam , Nu }
    public class Employee
    {
        public int Id { set; get; }

        [Display(Name = " Ma Nhan Vien ")]
        [Remote(action:"CheckEmployeeId",controller: "Employee")] //"Validation" Controller
        public int EmployeeId { set; get; } /// ? truoc type  / khac string thi buoc long phai nhap

        [Display(Name = " Ten Nhan Vien ")]
        public string EmployeeName { set; get; }

        [Display(Name = " Gioi Tinh ")]
        public Gender Gender { set; get; }

        [CheckDateOfBirth]  // tu dinh nghia BAI8*CUSTOM Validation 
        [Display(Name = " Ngay Sinh ")]
        [DataType(DataType.Date)] // make the choosing bar show DATE only 
        public DateTime DateOfBirth { set; get; }

    }


    //custom validatiopn  https://hienlth.info/aspcore/2.Labs/ASPCore-Lab08-Validation.pdf 
    public class CheckDateOfBirthAttribute : ValidationAttribute // gan chu validation vao !
    {
         public CheckDateOfBirthAttribute() : base("Ngay sinh khong hop le") // constructer  
        {

        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) // protected override  : ghi de
        {
            // yeu cau :: nagy sinh nhan vien lon hon hoac bang 10 tuoi 


            DateTime dob = (DateTime) value;

            if (dob >= DateTime.Now)
            {
                return new ValidationResult("chua sinh ra");
            }

            if (dob.AddYears(10) > DateTime.Now) // ngay sinh +10 nam 
            {
                return new ValidationResult(" van con tre ");
            }

            return ValidationResult.Success;
            //return base.IsValid(value, validationContext);
        }
       
    }
}
