using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCore1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;
        private static List<Post> Posts = new List<Post>
            {
                new Post{Name="Murad",Desc="Ela Post"},
                new Post{Name="Ruslan",Desc="Pis Post"}
            };
        public HomeController(AppDbContext context)
        {

            this.context = context;
        }
        public IActionResult Index()
        {
            var data = context.Posts.Where(i => i.Name == "Salam")
                .FirstOrDefault();

            var dataWithComments = context.Posts.Include(i => i.Comments)
                .Where(i => i.Id == 5).FirstOrDefault();


            var dataWithQuery = context.Comments.FromSql(new RawSqlString("Select * from Comments"));

            var dataWithCommentsL2S = from post in context.Posts
                                      join comment in context.Comments
                                      on post.Id equals comment.PostId
                                      select new { post, comment };

            //var post = context.Posts.Add(new Post()).Entity;

            var dataWithCommentsJoinWhere = from post in context.Posts
                                            from comment in context.Comments
                                            where post.Id == comment.PostId
                                            select new { post, comment };

            var data2 = (from post in context.Posts
                         where post.Name == "Salam"
                         select new { post }).FirstOrDefault();



            return View();
        }

        public IActionResult Privacy()
        {
            //ViewBag.Data = "Salam";
            //TempData["Data"] = name;
            UserSkills data = new UserSkills
            {
                UserId = 1,
                SkillId = 5
            };
            context.UserSkills.Add(data);


            context.UserSkills.Include(i => i.Skill)
                .ThenInclude(i => i.Comments)
                .ThenInclude(i => i.Post)
                .ThenInclude(i => i.Category)
                .Include(i=>i.User)
                .Where();
            return View(Posts);

            //context.Post.Include(i=>i.Comments).ThenInclude(a=>a.User)
        }

        [HttpPost]
        public IActionResult PostFromAjax([FromBody]Post post)
        {
            //TempData["Data"] = post.Desc;
            //return RedirectToAction("Privacy",new { name=post.Name });
            Posts.Add(post);
            return Json(Posts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
