using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLesson._2814.Models
{
    public class ToDo
    {
        public ToDo()
        {
            ToDoItems = new List<ToDoItem>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDoItem> ToDoItems { get; set; }
    }
}
