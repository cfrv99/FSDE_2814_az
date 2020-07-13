using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.DTOs;
using ToDoApp.Models;
using ToDoApp.Services.Abstract;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoService toDoService;

        public ToDoController(IToDoService toDoService)
        {
            this.toDoService = toDoService;
        }

        public IActionResult GetAllToDo()
        {
            var data = toDoService.GetAll();
            return View(data);
        }
        [HttpPost]
        public IActionResult Add(ToDoAddDTO model)
        {
            ToDo toDo = new ToDo
            {
                Title = model.Title,
                IsDone = false
            };
            toDoService.Add(toDo);
            return RedirectToAction("GetAllToDo");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = toDoService.Delete(id);
            if (result == "OK")
            {
                return RedirectToAction("GetAllToDo");
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult SelectTask(SeletctToDoDTO model,bool IsDone)
        {

            if (model.Id <= 0)
            {
                return BadRequest();
            }
            ToDo toDo = new ToDo
            {
                Id = model.Id,
                IsDone = IsDone
            };
            toDoService.SelectTask(toDo);

            return RedirectToAction("GetAllToDo");
        }
    }
}
