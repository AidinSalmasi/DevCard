using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "لطفا نام را وارد کنید")]
        [MinLength(3)]
        [MaxLength(100)]
        public string  Name { get; set; }
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        [EmailAddress(ErrorMessage = "ایمل وارد شده صحیح نیست")]
        public string Email { get; set; }

        public string Massage { get; set; }
        [Required(ErrorMessage = "سرویس مورد نظر خود را انتخاب کنید")]
        public int  Service { get; set; }

        public SelectList Services { get; set; }
    }
}
