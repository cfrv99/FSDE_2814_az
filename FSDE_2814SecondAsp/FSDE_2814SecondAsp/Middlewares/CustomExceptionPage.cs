using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FSDE_2814SecondAsp.Middlewares
{
    public class CustomExceptionPage
    {
        private RequestDelegate next;

        public CustomExceptionPage(RequestDelegate next)
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
                await HandleException(context, ex);
            }
        }

        private async Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "text/html";
            string html = File.ReadAllText("./wwwroot/ExPage.html");
            html = html.Replace("~ErrorMessage~", ex.Message);
            html = html.Replace("~statuscode~", context.Response.StatusCode.ToString());
            await context.Response.WriteAsync(html);

        }
    }
}
