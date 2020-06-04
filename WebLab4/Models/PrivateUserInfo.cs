using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebLab4.Models
{
    public class PrivateUserInfo
    {
        [EmailAddress]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string email { get; set; }
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string password { get; set; }
        [Compare("password", ErrorMessage = "Пароли не совпадают")]
        public string confirmPassword { get; set; }
    }
}
