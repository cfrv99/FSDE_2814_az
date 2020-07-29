using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuth.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [MinLength(5)]
        public string Login { get; set; }

        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
