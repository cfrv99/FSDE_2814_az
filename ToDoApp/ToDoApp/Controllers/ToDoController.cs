using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var selectList = new SelectList(data,"Id","Title");
            ViewBag.ToDos = selectList;
            ToDoListViewModel entity = new ToDoListViewModel
            {
                
            };
            var a = HttpContext.Request.GetDisplayUrl(); 
            return View(entity);
        }
        [HttpPost]
        public IActionResult Add(ToDoListViewModel model)
        {
            ToDo toDo = new ToDo
            {
                Title = model.ToDo.Title,
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
        public IActionResult SelectTask(SeletctToDoDTO model)
        {

            var uri = Url.Action("Delete", "ToDo", new { id = 5 });

            //https://localhost:5000/ToDo/Delete/5

            if (model.Id <= 0)
            {
                return BadRequest();
            }
            ToDo toDo = new ToDo
            {
                Id = model.Id,
                IsDone = model.IsDone
            };
            toDoService.SelectTask(toDo);
            
            return RedirectToAction("GetAllToDo");
        }

        //1. her bir view parcasi ucun ayri bir davranish (yeni backend ) yaza bilirk.
        // 2.

    }
}
