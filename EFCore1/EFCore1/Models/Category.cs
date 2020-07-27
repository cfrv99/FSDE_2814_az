using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
