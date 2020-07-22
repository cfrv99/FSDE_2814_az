using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using ToDoApp.Services.Abstract;

namespace ToDoApp.Controllers
{
    public class TestController:Controller
    {
        private readonly IToDoService toDoService;

        public TestController(IToDoService toDoService)
        {
            this.toDoService = toDoService;
        }
        [HttpGet]
        public IActionResult A(Test model)
        {
            ToDo toDo = new ToDo
            {
                Rating = 5
            };

            ToDo toDo1 = toDoService.GetById(1);
            return View();
        }
        [HttpPost]
        public IActionResult B(List<ToDo> toDos)
        {
            return RedirectToAction("A");
        }

        public IActionResult TagHelper()
        {
            return View(new ToDo() { Title="Murad" });
        }

        [HttpPost]
        public IActionResult Post(ToDo model)
        {
            return NoContent();
        }
    }
}
