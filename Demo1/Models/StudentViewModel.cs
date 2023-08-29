using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Models
{
    public class StudentViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "فبلد الزامی است")]

        public string Username { get; set; }

        [Display(Name = "پست الکترونیک")]
        [EmailAddress(ErrorMessage = "ایمیل بزن لنتی زرنگ")]

        public string Email { get; set; }

        [Range(18,90,ErrorMessage ="سن در بازه نیست")]
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        
        
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Repassword { get; set; }

        //[MaxLength(20,ErrorMessage ="")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "طول مجاز نیست")]
        public string Description { get; set; }
        public bool Confirm { get; set; }


    }
}
