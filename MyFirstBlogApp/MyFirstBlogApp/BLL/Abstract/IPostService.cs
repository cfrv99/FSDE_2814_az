using MyFirstBlogApp.DTOs;
using MyFirstBlogApp.DTOs.Response;
using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.BLL.Abstract
{
    public interface IPostService
    {
        void Add(PostModel post);
        void Update(PostModel post);
        void Delete(int id);

        List<AllPostModel> GetAll();
        PostDetailsModel GetById(int id);
        List<AllPostModel> GetByCategoryId(int categoryId);


    }
}
