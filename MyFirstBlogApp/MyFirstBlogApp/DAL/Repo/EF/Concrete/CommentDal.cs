using MyFirstBlogApp.DAL.Contexts;
using MyFirstBlogApp.DAL.Repo.EF.Abstract;
using MyFirstBlogApp.DAL.Repo.EF.Base;
using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.DAL.Repo.EF.Concrete
{
    public class CommentDal : EfRepository<Comment>, ICommentRepository
    {
        public CommentDal(AppDbContext context) : base(context)
        {
        }
    }
}
