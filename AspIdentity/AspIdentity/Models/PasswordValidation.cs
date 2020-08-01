using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspIdentity.Models
{
    public class PasswordValidation : IPasswordValidator<User>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            //if (user.UserName != password && !passwords.Contains(password))
            //{
            //    return Task.FromResult(IdentityResult.Success);
            //}

            //var error = new IdentityError
            //{
            //    Code = "login_validation",
            //    Description = "Your password is not secure!"
            //};
            //return Task.FromResult(IdentityResult.Failed(error));
            return Task.FromResult(IdentityResult.Success);
        }
    }
}
