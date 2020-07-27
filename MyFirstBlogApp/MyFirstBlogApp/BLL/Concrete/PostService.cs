using Microsoft.EntityFrameworkCore;
using MyFirstBlogApp.BLL.Abstract;
using MyFirstBlogApp.DAL.Repo.EF.Abstract;
using MyFirstBlogApp.DTOs;
using MyFirstBlogApp.DTOs.Response;
using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.BLL.Concrete
{
    public class PostService : IPostService
    {
        private readonly IPostRepository postRepository;

        public PostService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
        public void Add(PostModel post)
        {
            Post entity = new Post
            {
                CategoryId = post.CategoryId,
                ViewedCount = 0,
                ImageUrl = post.ImageUrl,
                Desc = post.Desc,
                Name = post.Name,
                Rating = 0
            };
            postRepository.Add(entity);
        }

        public void Delete(int id)
        {
            postRepository.Delete(id);
        }

        public List<AllPostModel> GetAll()
        {
            var result = postRepository.GetWithInclude(a => a.Category).Select(i => new AllPostModel
            {
                Id = i.Id,
                CategoryId = i.CategoryId,
                CategoryName = i.Category.Name,
                ViewedCount = i.ViewedCount,
                Desc = i.Desc,
                ImageUrl = i.ImageUrl,
                Name = i.Name,
                CreatedDate = i.CreatedDate.ToString("MMMM dd"),
                Rating = i.Rating
            });
            return result.ToList();
        }

        public List<AllPostModel> GetByCategoryId(int categoryId)
        {
            var result = postRepository.Find(i => i.CategoryId == categoryId)
                .Select(i=>new AllPostModel
            {
                CategoryId = i.CategoryId,
                CategoryName = i.Category.Name,
                ViewedCount = i.ViewedCount,
                Desc = i.Desc,
                ImageUrl = i.ImageUrl,
                Name = i.Name,
                Rating = i.Rating
            });
            return result.ToList();
        }

        public PostDetailsModel GetById(int id)
        {
            var result = postRepository.GetByIdWithInclude(id);

            PostDetailsModel postDetailsModel = new PostDetailsModel
            {
                CategoryId = result.CategoryId,
                CategoryName = result.Category.Name,
                ViewedCount = result.ViewedCount,
                Desc = result.Desc,
                ImageUrl = result.ImageUrl,
                Name = result.Name,
                Rating = result.Rating,
                CommentList = postRepository.GetCommentsByPostId(id)
            };

            return postDetailsModel;
        }

        public void Update(PostModel post)
        {
            if (post.Id <= 0)
            {
                throw new Exception("Id can not be null");
            }
            Post entity = new Post
            {
                Id = post.Id,
                CategoryId = post.CategoryId,
                ViewedCount = post.ViewedCount,
                ImageUrl = post.ImageUrl,
                Desc = post.Desc,
                Name = post.Name,
                Rating = post.Rating
            };
            postRepository.Update(entity);
        }
    }
}
