using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLesson._2814.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ToDo ToDo { get; set; }
        public int ToDoId { get; set; }
    }
}
