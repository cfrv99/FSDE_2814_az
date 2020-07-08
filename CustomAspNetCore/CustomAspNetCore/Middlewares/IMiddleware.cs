using CustomAspNetCore.Server;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CustomAspNetCore.Middlewares
{
    public interface IMiddleware
    {
        HttpHandler next { get; set; }
        void Invoke(HttpListenerContext context);
    }
}
