using MyFirstBlogApp.DAL.Repo.EF.Base;
using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.DAL.Repo.EF.Abstract
{
    public interface ICommentRepository:IRepository<Comment>
    {
    }
}
