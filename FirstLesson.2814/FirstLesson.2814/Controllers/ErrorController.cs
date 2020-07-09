using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLesson._2814.Controllers
{
    public class ErrorController:Controller
    {
        [Route("/error")]
        public IActionResult Errors()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context.Error;
            HttpContext.Response.StatusCode = 404;
            return View();
        }
    }
}
