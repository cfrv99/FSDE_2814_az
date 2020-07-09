using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLesson._2814.Middlewares
{
    public class CustomErrorHandlingMiddleware
    {
        private RequestDelegate next;

        public CustomErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleException(context,ex);
            }
        }

        private async Task HandleException(HttpContext context,Exception ex)
        {
            context.Response.ContentType = "text/html";

            string html = File.ReadAllText("./wwwroot/Error.html");
            html = html.Replace("~ErrorMessage~", ex.Message);
            await context.Response.WriteAsync(html);
        }
    }
}
