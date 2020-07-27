using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore1.Models
{
    public class Post
    {
        private int _rating;
        private int _ratedCount;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int ViewedCount { get; set; }
        public int Rating { get; set; }
        public int RaiterCount { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
