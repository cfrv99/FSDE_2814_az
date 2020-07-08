using CustomAspNetCore.Server;
using System;
using System.Net;

namespace CustomAspNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServerBuilder webServer = new WebServerBuilder("http://localhost", 8080);
            webServer.UseStartup<Startup>();
            webServer.Run();
        }
    }
}
