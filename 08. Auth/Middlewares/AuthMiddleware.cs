using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MVCAuth.Encryptors;
using MVCAuth.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuth.Middlewares
{
    public class AuthMiddleware
    {
        private RequestDelegate next;

        public AuthMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, IUserManager userManager)
        {
            //IUserManager userManager = context.RequestServices.GetRequiredService<IUserManager>();
            userManager.GetCredentials();
                await next.Invoke(context);
        }
    }
}
