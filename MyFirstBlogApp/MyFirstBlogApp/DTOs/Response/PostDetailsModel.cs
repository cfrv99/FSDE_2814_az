using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.DTOs.Response
{
    public class PostDetailsModel
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string ImageUrl { get; set; }
        public int ViewedCount { get; set; }
        public int Rating { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Comment> CommentList { get; set; }
    }
}
