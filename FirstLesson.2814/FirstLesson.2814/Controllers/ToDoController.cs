using FirstLesson._2814.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstLesson._2814.Controllers
{
    public class ToDoController : Controller
    {
        private static List<ToDo> GetToDos = new List<ToDo>
        {
            new ToDo{ Id=1,Name="Salam", ToDoItems = new List<ToDoItem>
                {
                    new ToDoItem { Id = 1,Name="SalamItem", ToDoId = 1}
                }
            }
        };
        [HttpGet]
        public IActionResult GetAll()
        {
            return View(GetToDos);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var todo = GetToDos.FirstOrDefault(i => i.Id == id);
            return View(todo);
        }

        [HttpPost]
        public IActionResult Add(ToDoItem item)
        {
            var todo = GetToDos.FirstOrDefault(i => i.Id == item.ToDoId);
            int max = 0;
            if (todo.ToDoItems.Count > 0)
            {
                max = todo.ToDoItems.Max(i => i.Id);
            }
            item.Id = max + 1;
            todo.ToDoItems.Add(item);
            var todos = GetToDos;
            return RedirectToAction("Details", new { id = item.ToDoId });
        }

        [HttpPost]
        public IActionResult Delete(int id, int toDoId)
        {
            var todo = GetToDos.FirstOrDefault(i => i.Id == toDoId);
            var todoItem = todo.ToDoItems.FirstOrDefault(i => i.Id == id);
            todo.ToDoItems.Remove(todoItem);
            return RedirectToAction("Details", new { id = toDoId });
        }

    }
}
