using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuth.Models
{
    public class UserCredentials
    {
        public string Login { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime Expiration { get; set; }
    }
}
