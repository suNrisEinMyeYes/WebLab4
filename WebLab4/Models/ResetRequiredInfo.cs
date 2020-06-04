using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebLab4.Models
{
    public class ResetRequiredInfo
    {
        [EmailAddress]
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        public string email { get; set; }
    }
}
