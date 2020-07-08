using CustomAspNetCore.Middlewares;
using CustomAspNetCore.Pipelines;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAspNetCore
{
    public class Startup : IConfigurator
    {

        public void Configure(MiddlewareBuilder middlewareBuilder)
        {
            middlewareBuilder.Use<StaticMiddleware>();
            middlewareBuilder.Use<MvcMiddleware>();
            //middlewareBuilder.Use<LoggingMiddleware>();
            //middlewareBuilder.Use<HtmlFileMiddleware>();
        }
    }
}
