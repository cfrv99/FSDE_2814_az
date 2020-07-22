using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyFirstBlogApp.BLL.Abstract;
using MyFirstBlogApp.DAL.Repo.EF.Abstract;
using MyFirstBlogApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostsController:Controller
    {
        private readonly IPostService postService;
        private readonly ICategoryService categoryService;

        public PostsController(IPostService postService,ICategoryService categoryService)
        {
            this.postService = postService;
            this.categoryService = categoryService;
        }

        public IActionResult GetAll()
        {
            var data = postService.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult CreateView()
        {
            var categoryList = categoryService.GetAll();
            var selectCategoryList = new SelectList(categoryList, "Id", "Name");
            ViewBag.Categories = selectCategoryList;
            return View(new PostModel());
        }
        [HttpPost]
        public IActionResult Create(PostModel model)
        {
            postService.Add(model);
            return Redirect("/Admin/Posts/GetAll");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var result = postService.GetById(id); 
            return View(result);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            postService.Delete(id);
            return RedirectToAction("GetAll","Posts");
        }
    }
}
