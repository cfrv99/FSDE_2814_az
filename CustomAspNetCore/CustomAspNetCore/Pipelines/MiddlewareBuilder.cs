using CustomAspNetCore.Middlewares;
using CustomAspNetCore.Server;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CustomAspNetCore.Pipelines
{
    public class MiddlewareBuilder
    {
        private Stack<Type> types = new Stack<Type>();

        public MiddlewareBuilder Use<T>() where T : IMiddleware
        {
            types.Push(typeof(T));
            return this;
        }
        public HttpHandler Build()
        {
            HttpHandler handler = context => context.Response.Close();
            while (types.Count > 0)
            {
                Type type = types.Pop();
                var middlerware = Activator.CreateInstance(type, handler) as IMiddleware;
                handler = middlerware.Invoke;
            }
            return handler;
        }
    }
}
