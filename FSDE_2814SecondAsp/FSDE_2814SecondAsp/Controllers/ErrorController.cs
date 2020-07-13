using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDE_2814SecondAsp.Controllers
{
    public class ErrorController:Controller
    {
        public ErrorController()
        {

        }
        [Route("/error")]
        public IActionResult Errors()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context.Error;
            HttpContext.Response.StatusCode = 404;
            return View();
        }

        [HttpGet]
        public IActionResult SSS()
        {
            return View();
        }
    }
}
