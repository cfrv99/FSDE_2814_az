using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.Handler.CustomValidators
{
    public class ValidEmailDomainAttribute : ValidationAttribute
    {
        private readonly string allowedDomain;

        public ValidEmailDomainAttribute(string allowedDomain)
        {
            this.allowedDomain = allowedDomain;
        }

        public override bool IsValid(object value)
        {

            //cmurad@mit.az
            string[] strings = value.ToString().Split("@");
            return strings[1].ToUpper() == allowedDomain.ToUpper();
        }
    }
}
