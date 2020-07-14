using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class TestController:Controller
    {
        [HttpGet]
        public IActionResult A(Test model)
        {
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
