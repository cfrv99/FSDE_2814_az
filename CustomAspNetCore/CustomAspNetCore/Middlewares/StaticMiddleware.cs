using CustomAspNetCore.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CustomAspNetCore.Middlewares
{
    public class StaticMiddleware : IMiddleware
    {
        public StaticMiddleware(HttpHandler next)
        {
            this.next = next;
        }

        public HttpHandler next { get; set; }
        

        public void Invoke(HttpListenerContext context)
        {                                               // localhost:8080/index
            if (context.Request.RawUrl.Contains("."))
            {
                var types = new Dictionary<string, string>()
                {
                    ["html"] = "text/html",
                    ["css"] = "text/css",
                    ["json"] = "application/json",
                    ["xml"] = "application/xml",
                    ["ico"] = "image/x-icon"
                };

                var path = "wwwroot" + context.Request.RawUrl;

                if (File.Exists(path))  //  localhiost:8080/index.html   path = wwwroot/index. html
                {
                    var file = File.ReadAllBytes(path);
                    var type = types[path.Split(".").Last()];
                    context.Response.ContentType = type;
                    context.Response.OutputStream.Write(file, 0, file.Length);
                }
                else
                {
                    context.Response.StatusCode = 404;
                    Console.WriteLine("Bele File yoxdui!!!");
                }
                context.Response.Close();
            }
            else
            {
                next?.Invoke(context);
            }
            

        }
    }
}
