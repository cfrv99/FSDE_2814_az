using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDoListViewModel
    {
        public List<ToDo> ToDos { get; set; }
        public ToDo ToDo { get; set; }
    }
}
