using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Test
    {
        public Test2 Test2 { get; set; }
    }
    public class Test2
    {
        public Test3 Test3 { get; set; }
    }
    public class Test3
    {
        public string Surname { get; set; }
    }
}
