using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAuth.Filters
{
    public class TestActionFilter: Attribute, IActionFilter
    {
        public string Message { get; set; }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Cookies.Append("test", DateTime.Now.ToString());
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.Controller is Controller controller)
            {
                controller.ViewBag.FilterData = Message;
            }
        }
    }
}
