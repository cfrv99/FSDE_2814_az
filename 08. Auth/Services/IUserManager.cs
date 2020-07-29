using MVCAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuth.Services
{
    public interface IUserManager
    {
        public UserCredentials CurrentUser { get; set; }
        bool Login(string username, string password);
        UserCredentials GetCredentials();
    }
}
