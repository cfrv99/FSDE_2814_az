using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBlogApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int ViewedCount { get; set; }
    }
}
