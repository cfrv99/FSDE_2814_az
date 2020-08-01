using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspIdentity.ViewModel
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Username bosh ola bilmez")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password bosh ola bilmez!")]
        public string Password { get; set; }
    }
}
