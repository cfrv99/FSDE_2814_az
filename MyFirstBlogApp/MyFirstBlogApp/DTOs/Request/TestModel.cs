using Microsoft.AspNetCore.Mvc;
using MyFirstBlogApp.Handler.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.DTOs.Request
{
    public class TestModel
    {
        

        //Fluent Validadtion
        [Required(ErrorMessage = "Surname bosh olanmaz")]
        [MinLength(20, ErrorMessage = "20 den yuxari ola bilmez")] 
        public string Surname { get; set; }
        public string Name { get; set; }
        //[EmailAddress]
        [ValidEmailDomain("@mit.az",ErrorMessage = "Email bele ola bilmez")]
        public string Email { get; set; }
        [Range(18,50)]
        public int Age { get; set; }
    }
}
