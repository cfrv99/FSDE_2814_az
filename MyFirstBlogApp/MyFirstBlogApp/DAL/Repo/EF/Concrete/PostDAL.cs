using Microsoft.EntityFrameworkCore;
using MyFirstBlogApp.DAL.Contexts;
using MyFirstBlogApp.DAL.Repo.EF.Abstract;
using MyFirstBlogApp.DAL.Repo.EF.Base;
using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFirstBlogApp.DAL.Repo.EF.Concrete
{
    public class PostDAL : EfRepository<Post>, IPostRepository
    {
        public PostDAL(AppDbContext context) : base(context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public Post GetByIdWithInclude(int id)
        {
            return Context.Posts.Include(i => i.Category).FirstOrDefault(i => i.Id == id);
            
        }

        public List<Comment> GetCommentsByPostId(int postId)
        {
            return Context.Comments.Where(i => i.PostId == postId).ToList();
        }

        public Post GetPostByCommentId(int id)
        {
            throw new NotImplementedException();

        }
    }
}
