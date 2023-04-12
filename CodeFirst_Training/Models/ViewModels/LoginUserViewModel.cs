using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Training.Models.ViewModels
{
    public class LoginUserViewModel
    {
        [Display(Name ="شماره موبایل")]
        [Required(ErrorMessage ="فیلد {0} اجباری است!")]
        [RegularExpression("(09)[0-9]{9}",ErrorMessage = "فرمت {0} صحیح نیست!")]
        public string UserName { get; set; }

        [Display(Name ="رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [DataType(DataType.Password,ErrorMessage = "فرمت {0} صحیح نیست!")]
        public string Password { get; set; }
    }
}