using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class RegisterForm
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pass { get; set; }
        public IFormFile File { get; set; }
    }
}
