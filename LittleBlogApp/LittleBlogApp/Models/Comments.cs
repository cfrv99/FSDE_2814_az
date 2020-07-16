using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBlogApp.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int PostId { get; set; }
    }
}
