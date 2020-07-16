using Microsoft.AspNetCore.Mvc;
using SlugTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlugTestApp.Controllers
{
    public class UsersController : Controller
    {
        private static List<User> GetUsers;
        public UsersController()
        {
            GetUsers = new List<User>
            {
                new User{Id = 1,Name = "Murad",Desc = "Ela oglandi"},
                new User{Id = 2,Name = "Ilham",Desc = "Lap Ela oglandi"},
                new User{Id = 3,Name = "Orxan",Desc = "Lap Lap Ela oglandi"}
            };
        }
        [Route("butunUserler")]
        [Route("allUsers")]
        [Route("users")]
        [Route("/")]
        public ActionResult GetAllUsers()
        {
            var data = GetUsers;
            return View(data);
        }
        public IActionResult GetById(int id)
        {
            var data = GetUsers.FirstOrDefault(i => i.Id == id);
            return View(data);
        }
    }
}
