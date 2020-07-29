using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuth.Filters
{
    public class CustomExFilter : Attribute,IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var ex = context.Exception;
            if (ex != null)
            {
                context.Result = new RedirectToActionResult("Error","Home","");
            }
        }
    }
}
