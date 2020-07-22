using MyFirstBlogApp.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.Entities
{
    public class Category:EntityBase
    {     
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}
