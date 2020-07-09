using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDE_2814SecondAsp.Middlewares
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseCustomError(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomExceptionPage>();
        }
    }
}
