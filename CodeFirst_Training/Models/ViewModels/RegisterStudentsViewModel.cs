using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Training.Models.ViewModels
{
    public class RegisterStudentsViewModel
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [MaxLength(20), MinLength(2,ErrorMessage ="حداقل 2 کارکتر و حداکثر 20 باید باشد ")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [MaxLength(30), MinLength(2, ErrorMessage = "حداقل 2 کارکتر و حداکثر 20 باید باشد ")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Family { get; set; }

        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "فرمت شماره موبایل صحیح نیست!")]
        public string Phone { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="رمز عبور با تکرار آن مطابقت ندارد!")]
        public string PasswordConfirm { get; set; }
    }
}