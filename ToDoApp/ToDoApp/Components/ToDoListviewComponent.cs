using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Services.Abstract;

namespace ToDoApp.Components
{
    public class ToDoListViewComponent:ViewComponent
    {
        private readonly IToDoService toDoService;

        public ToDoListViewComponent(IToDoService toDoService)
        {
            this.toDoService = toDoService;
        }

        public IViewComponentResult Invoke()
        {
            var data = toDoService.GetAll().Where(i=>i.Title.Length>3);
            return View(data);
        }
    }
}
