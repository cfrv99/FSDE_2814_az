using Microsoft.AspNetCore.Mvc;
using MyFirstBlogApp.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        public IActionResult GetAllPost()
        {
            var data = postService.GetAll();
            return View(data);
        }
    }
}
