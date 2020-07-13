using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Services.Abstract
{
    public interface IToDoService
    {
        ToDo GetById(int id);
        List<ToDo> GetAll();
        void Add(ToDo entity);
        void Update(ToDo entity);
        string Delete(int id);
        void SelectTask(ToDo toDo);
    }
}
