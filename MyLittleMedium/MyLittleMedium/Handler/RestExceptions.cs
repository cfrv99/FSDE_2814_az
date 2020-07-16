using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MyLittleMedium.Handler
{
    public class RestExceptions : Exception
    {
        public string Message { get; set; }
        public HttpStatusCode Code { get; set; }
        public RestExceptions(HttpStatusCode code, string message)
        {
            Message = message;
            Code = code;
        }
    }
}
