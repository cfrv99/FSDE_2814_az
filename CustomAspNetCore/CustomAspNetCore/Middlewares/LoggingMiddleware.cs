using CustomAspNetCore.Server;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CustomAspNetCore.Middlewares
{
    public class LoggingMiddleware : IMiddleware
    {
        public HttpHandler next { get; set; }

        public LoggingMiddleware(HttpHandler next)
        {
            this.next = next;
        }
        public void Invoke(HttpListenerContext context)
        {
            Console.WriteLine($"Method: {context.Request.HttpMethod}, HttpRequest Path: {context.Request.RawUrl}, DateTime: {DateTime.Now}");
            next?.Invoke(context);
        }
    }
}
