using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFirstBlogApp.Handler
{
    public static class CustomSelect
    {
        public static IEnumerable<T> SelectHandler<T>(this IEnumerable<T> queryable, Func<T, bool> func)
        {
            List<T> list = new List<T>();
            foreach (var item in queryable)
            {
                if (func(item))
                {
                    list.Add(item);
                }

            }
            return list.AsEnumerable();
        }
    }
}
