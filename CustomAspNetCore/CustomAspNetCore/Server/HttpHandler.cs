using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CustomAspNetCore.Server
{
    public delegate void HttpHandler(HttpListenerContext context);
}
