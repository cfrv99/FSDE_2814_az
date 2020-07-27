using MyFirstBlogApp.Entities;
using MyFirstBlogApp.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.Factory
{
    public class ClassFactory
    {
        public static IEntityBase CreateInstance(IEntityBase type)
        {
            var typeData = type.GetType();
            var result = Activator.CreateInstance(typeData) as IEntityBase;
            return result;
        }
    }
}
