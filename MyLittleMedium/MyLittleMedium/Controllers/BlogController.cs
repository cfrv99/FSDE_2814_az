using Microsoft.AspNetCore.Mvc;
using MyLittleMedium.Entities;
using MyLittleMedium.Models;
using MyLittleMedium.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleMedium.Controllers
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
        [HttpGet]
        public IActionResult GetAllPost()
        {
            return View(postService.GetAll());
        }

        [HttpGet]
        public IActionResult Details(int id, bool? fromRedirect)
        {
            if (fromRedirect == null)
            {
                postService.IncrementViewedCount(id);
            }
            var post = postService.GetById(id);
            var comments = commentService.GetCommentsByPost(id);

            PostDetailsviewModel model = new PostDetailsviewModel
            {
                Post = post,
                Comments = comments
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = postService.GetById(id);
            postService.Delete(data);
            return RedirectToAction("GetAllPost");
        }

        [HttpGet]
        public IActionResult DeleteComment(int id,int currentPostId)
        {
            var data = commentService.GetById(id);
            commentService.Delete(data);
            return RedirectToAction("Details");
        }

        [HttpPost]
        public IActionResult AddComment(PostDetailsviewModel model)
        {
            Comment comment = new Comment
            {
                PostId = model.Comment.PostId,
                Text = model.Comment.Text
            };
            commentService.Add(comment);
            return RedirectToAction("Details", new { id = model.Comment.PostId, fromRedirect = true });
        }
    }
}
