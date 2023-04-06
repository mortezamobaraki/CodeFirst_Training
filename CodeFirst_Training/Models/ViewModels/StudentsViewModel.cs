using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Training.Models.ViewModels
{
    public class StudentsViewModel
    {
        [Display(Name="نام")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Display(Name = "شماره موبایل")]
        public string Phone { get; set; }

        [Display(Name = "آدرس ایمیل")]
        public string Email { get; set; }
    }
}