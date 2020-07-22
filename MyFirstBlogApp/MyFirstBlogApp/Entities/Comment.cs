using MyFirstBlogApp.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.Entities
{
    public class Comment:EntityBase
    {
        public string Text { get; set; }
        public string UserBy { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
