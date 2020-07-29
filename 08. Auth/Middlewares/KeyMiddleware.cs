using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuth.Middlewares
{
    public class KeyMiddleware
    {
        private RequestDelegate next;

        public KeyMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var key = context.Request.Query["key"];
            if (key == "qwerty")
            {
                await next.Invoke(context);
            }
            else
            { 
                await context.Response.WriteAsync("Goodbye!"); 
            }
        }
    }
}
