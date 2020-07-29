using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using MVCAuth.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuth.Filters
{
    public class AuthorizeFilter : Attribute, IAuthorizationFilter
    {
        //private readonly IUserManager userManager;

        //public AuthorizeFilter(IUserManager userManager)
        //{
        //    this.userManager = userManager;
        //}

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            IUserManager userManager = context.HttpContext.RequestServices.GetRequiredService<IUserManager>();
            if (userManager.CurrentUser == null)
            {
                context.Result = new RedirectToActionResult("Privacy", "Home", null);
            }
            
        }
    }
}
