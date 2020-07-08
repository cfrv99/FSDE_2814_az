using CustomAspNetCore.Middlewares;
using CustomAspNetCore.Pipelines;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace CustomAspNetCore.Server
{
    public class WebServerBuilder
    {
        public string Domain { get; set; }
        public int Port { get; set; }
        private HttpListener httpListener;
        private HttpHandler middleware;
        public WebServerBuilder(string domain, int port)
        {
            Domain = domain;
            Port = port;
            httpListener = new HttpListener();
            httpListener.Prefixes.Add($"{Domain}:{Port}/");
        }

        public void UseStartup<T>() where T : IConfigurator, new()
        {
            var config = new T();
            var builder = new MiddlewareBuilder();
            config.Configure(builder);
            middleware = builder.Build();
        }

        public void Run()
        {
            httpListener.Start();
            while (true)
            {
                var context = httpListener.GetContext();
                Process(context);
            }
        }

        public void Process(HttpListenerContext context)
        {
            middleware?.Invoke(context);
            context.Response.Close();
        }
        //public void Process(HttpListenerContext context)
        //{
        //    //Console.WriteLine(context.Request.RawUrl);
        //    string html = string.Empty;
        //    string url = context.Request.RawUrl;
        //    try
        //    {
        //         html = File.ReadAllText($"./wwwroot/{url}");
        //    }
        //    catch (Exception)
        //    {
        //        html = File.ReadAllText("./wwwroot/Error.html");
        //    }
        //    context.Response.ContentType = "text/html";
        //    using (var sw = new StreamWriter(context.Response.OutputStream))
        //    {
        //        sw.Write(html);
        //    }
        //    context.Response.Close();

        //}
    }
}
