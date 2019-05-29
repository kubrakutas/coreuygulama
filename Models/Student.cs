using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coreuygulama.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Lütfen isiim giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Lütfen mail giriniz")]
        [EmailAddress(ErrorMessage ="Mail adresini düzgün giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen telefon giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Lütfen katılım durumu giriniz")]
        public bool? isActive { get; set; }

    }
}
