using MyFirstBlogApp.DAL.Repo.EF.Base;
using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFirstBlogApp.DAL.Repo.EF.Abstract
{
    public interface IPostRepository : IRepository<Post>
    {
        Post GetPostByCommentId(int id);
        List<Comment> GetCommentsByPostId(int postId);
        Post GetByIdWithInclude(int id);
    }
}
