using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FirstLesson._2814
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // use 
            //run 
            //map
            //app.Use(async (context, next) =>
            //{
            //    if (context.Request.Path.HasValue)
            //    {
            //        await context.Response.WriteAsync("Good!!!");
            //        await next.Invoke();
            //    }
            //    else
            //    {
            //        return;
            //    }
            //});
            //app.Run(async (context) =>
            //{

            //    await context.Response.WriteAsync(context.Request.Path.Value.ToString());
            //});
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();  // /controllerName/actionName/{id?}
        }
    }
}
