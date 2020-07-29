using Microsoft.AspNetCore.Http;
using MVCAuth.Encryptors;
using MVCAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MVCAuth.Services
{
    public class UserManager : IUserManager
    {
        private readonly UsersDbContext context;
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserCredentials CurrentUser { get; set; }

        public UserManager(UsersDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.httpContextAccessor = httpContextAccessor;
        }

        public UserCredentials GetCredentials()
        {
            try
            {
                if (httpContextAccessor.HttpContext.Request.Cookies.ContainsKey("auth"))
                {
                    var hash = httpContextAccessor.HttpContext.Request.Cookies["auth"];
                    var json = AesEncryptor.DecryptString("b14ca5898a4e4133bbce2ea2315a1911", hash);
                    var user = JsonSerializer.Deserialize<UserCredentials>(json);
                    if (user.Expiration > DateTime.Now)
                    {
                        CurrentUser = user;
                        return CurrentUser;
                    }
                }
            }
            catch (Exception) { }
            return null;
        }

        public bool Login(string username, string password)
        {
            var passwordHash = Sha256Encryptor.Encrypt(password);
            var user = context.Users
                .FirstOrDefault(x => x.Login == username && x.PasswordHash == passwordHash);
            if (user != null)
            {
                var userCredentials = new UserCredentials
                {
                    Login = user.Login,
                    IsAdmin = user.IsAdmin,
                    Expiration = DateTime.Now + TimeSpan.FromSeconds(10)
                };
                var jsonUser = JsonSerializer.Serialize(userCredentials);
                var hash = AesEncryptor.EncryptString("b14ca5898a4e4133bbce2ea2315a1911", jsonUser);
                var cookieOptions = new CookieOptions();
                cookieOptions.HttpOnly = true;
                httpContextAccessor.HttpContext.Response.Cookies.Append("auth", hash, cookieOptions);
                return true;
            }
            return false;
        }
    }
}
