using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="پرکردن این فیلد اجباری می باشد.")]
        [MaxLength(length: 100,ErrorMessage ="حداکثر طول کاراکتر ها 100 می باشد.")]
        public string Name{ get; set; }
        [Required(ErrorMessage ="پر کردن این فیلد اجباری می باشد.")]
        [EmailAddress(ErrorMessage ="مقدار وارد شده صحیح نمی باشد.")]
        public string Email { get; set; }
        public int Service { get; set; }
        [Required(ErrorMessage = "پرکردن این فیلد اجباری می باشد.")]
        public string Message { get; set; }
        public SelectList Services { get; set; }
        
    }
}
