using Microsoft.Extensions.DependencyInjection;
using MyFirstBlogApp.BLL.Abstract;
using MyFirstBlogApp.BLL.Concrete;
using MyFirstBlogApp.DAL.Repo.EF.Abstract;
using MyFirstBlogApp.DAL.Repo.EF.Base;
using MyFirstBlogApp.DAL.Repo.EF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.Installers
{
    public static class RegisterService
    {
        public static void ServiceRegistration(this IServiceCollection services)
        {
            services.AddTransient<IPostRepository, PostDAL>();
            services.AddTransient<ICommentRepository, CommentDal>();
            services.AddTransient<ICategoryRepository, CategoryDAL>();
            services.AddTransient(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<ICategoryService, CategoryService>();
        } 
    }
}
