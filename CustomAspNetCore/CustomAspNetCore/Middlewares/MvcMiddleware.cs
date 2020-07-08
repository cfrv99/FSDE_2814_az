using CustomAspNetCore.Controllers;
using CustomAspNetCore.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;

namespace CustomAspNetCore.Middlewares
{
    public class MvcMiddleware : IMiddleware
    {
        public HttpHandler next { get; set; }

        public MvcMiddleware(HttpHandler next)
        {
            this.next = next;
        }

        public void Invoke(HttpListenerContext context)
        {
            try
            {
                var parts = context.Request.RawUrl.Split("?")[0].Split("/");  //https://thedotnetguide.com/mvc-design-pattern/shjhsjksjksj?search=salam
                var controllerName = parts[1] + "CONTROLLER";
                var methodName = parts[2];

                var controllerType = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .FirstOrDefault(i => i.Name.Equals(controllerName,
                    StringComparison.InvariantCultureIgnoreCase
                    ));
                if (controllerType == null)
                {
                    context.Response.StatusCode = 404;
                    Console.WriteLine("Sagol!!!");
                    context.Response.Close();
                    return;
                }
                var actionInfo = controllerType.GetMethods()
                    .FirstOrDefault(i => i.Name.Equals(methodName, StringComparison.InvariantCultureIgnoreCase));
                if (actionInfo == null)
                {
                    context.Response.StatusCode = 404;
                    Console.WriteLine("Yoxdu bele acton");
                    context.Response.Close();
                    return;
                }
                var controller = Activator.CreateInstance(controllerType);
                var pars = actionInfo.GetParameters();
                var args = new object[pars.Length];
                //?id=42&name=Ibrahim&age=19

                //arrayi doldurmaq ucun
                for (int i = 0; i < pars.Length; ++i)
                {
                    var val = context.Request.QueryString[pars[i].Name];
                    var type = pars[i].ParameterType;
                    var arg = Convert.ChangeType(val, type);
                    //Convert.ToInt32("");
                    args[i] = arg;
                }
                var result = actionInfo.Invoke(controller, args);

                context.Response.ContentType = "text/html";
                using (var sw = new StreamWriter(context.Response.OutputStream))
                {
                    sw.Write(result.ToString());
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Alinmadi!!!");
            }
        }
    }
}
