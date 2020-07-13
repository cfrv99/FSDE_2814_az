using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using ToDoApp.Services.Abstract;

namespace ToDoApp.Services.Concrete
{
    public class ToDoService:IToDoService
    {
        private static List<ToDo> DataContext;

        static ToDoService()
        {
            DataContext = new List<ToDo>
            {
                new ToDo{Id = 1, Title = "NewTodo" , IsDone = false},
                new ToDo {Id= 2,Title = "OldToDo", IsDone = true}
            };
        }

        public void Add(ToDo entity)
        {
            var newId = DataContext.Max(i => i.Id) + 1;
            entity.Id = newId;
            DataContext.Add(entity);
        }

        public string Delete(int id)
        {
            try
            {
                var todo = DataContext.FirstOrDefault(i => i.Id == id);
                DataContext.Remove(todo);
                return "OK";
            }
            catch (Exception)
            {
                return "Not Deleted";
            }
        }

        public List<ToDo> GetAll()
        {
            return DataContext.ToList();
        }

        public ToDo GetById(int id)
        {
            var todo = DataContext.FirstOrDefault(i => i.Id == id);
            return todo;
        }

        public void SelectTask(ToDo toDo)
        {
            if (toDo.Id <= 0)
            {
                throw new Exception("Id can not be null");
            }
            var todo = GetById(toDo.Id);
            todo.IsDone = toDo.IsDone;
        }

        public void Update(ToDo entity)
        {
            throw new NotImplementedException();
        }
    }
}
