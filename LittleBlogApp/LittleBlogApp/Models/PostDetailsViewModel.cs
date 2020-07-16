using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBlogApp.Models
{
    public class PostDetailsViewModel
    {
        public Post Post { get; set; }
        public List<Comments> Comments { get; set; }
        public Comments Comment { get; set; }
    }
}
