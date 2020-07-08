using CustomAspNetCore.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CustomAspNetCore.Middlewares
{
    public class HtmlFileMiddleware : IMiddleware
    {
        public HttpHandler next { get; set; }


        public HtmlFileMiddleware(HttpHandler next)
        {
            this.next = next;
        }
        public void Invoke(HttpListenerContext context)
        {
            string html = string.Empty;
            string url = context.Request.RawUrl;
            try
            {
                html = File.ReadAllText($"./wwwroot/{url}");
            }
            catch (Exception)
            {
                html = File.ReadAllText("./wwwroot/Error.html");
            }
            context.Response.ContentType = "text/html";
            using (var sw = new StreamWriter(context.Response.OutputStream))
            {
                sw.Write(html);
            }
            context.Response.Close();
            next?.Invoke(context);

        }
    }
}
