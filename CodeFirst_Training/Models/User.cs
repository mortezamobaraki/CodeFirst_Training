using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Training.Models
{
    [Table("T_User")]
    public class User
    {
        [Key]
        [Display(Name = "آیدی")]
        [Required(ErrorMessage ="فیلد {0} اجباری است")]
        public int UserId { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [MaxLength(20),MinLength(2)]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [MaxLength(30),MinLength(2)]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Family { get; set; }

        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [RegularExpression("(09)[0-9]{9}",ErrorMessage ="فرمت شماره موبایل صحیح نیست!")]
        public string Phone { get; set; }

        [Display(Name = "آدرس ایمیل")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [EmailAddress(ErrorMessage ="فرمت آدرس ایمیل صحیح نیست!")]
        public string AddressEmail { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تاریخ عضویت")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        [DisplayFormat(DataFormatString = "{0: dddd, dd MMMM yyyy}")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "فیلد {0} اجباری است")]
        public bool isActive { get; set; }
    }
}