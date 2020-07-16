using LittleBlogApp.Models;
using LittleBlogApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBlogApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostService postService;
        private readonly ICommentService commentService;

        public BlogController(IPostService postService, ICommentService commentService)
        {
            this.postService = postService;
            this.commentService = commentService;
        }

        public IActionResult GetAllPost()
        {
            return View(postService.GetAll());
        }

        public IActionResult GetByIdPost(int id, bool? fromRedirect)
        {
            if (fromRedirect == null)
            {
                postService.IncrementViewedCount(id);
            }

            var post = postService.GetById(id);
            var comments = commentService.GetCommentsByPostId(id);
            PostDetailsViewModel model = new PostDetailsViewModel
            {
                Post = post,
                Comments = comments
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddComment(PostDetailsViewModel model)
        {
            commentService.Add(model.Comment);
            return RedirectToAction("GetByIdPost", new { id = model.Comment.PostId, fromRedirect=true });
        }

        [HttpGet]
        public IActionResult DeleteComment(int id)
        {
            var data = commentService.GetById(id);
            commentService.Delete(data);
            return RedirectToAction(nameof(GetByIdPost));
        }

    }
}
