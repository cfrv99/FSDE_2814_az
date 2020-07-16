using LittleBlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBlogApp.Services
{
    public interface IPostService
    {
        void Add(Post entity);
        void Update(Post entity);
        void Delete(Post entity);
        List<Post> GetAll();
        Post GetById(int id);
        void IncrementViewedCount(int postId);

    }
    public class PostService : IPostService
    {
        private static List<Post> Posts;
        static PostService()
        {
            Posts = new List<Post>
            {
                new Post{Id=1,Name="Asp.Net Core",Desc="Asp.Net Core have the best performance as web technologies",ViewedCount = 0},
                new Post{Id=2,Name="Asp.Net MVC",Desc="Asp.Net MVC have the best performance as web technologies",ViewedCount = 0},
                new Post{Id=3,Name="PHP",Desc="PHP have the best performance as web technologies",ViewedCount = 0},
                new Post{Id=4,Name="Django",Desc="Django have the best performance as web technologies",ViewedCount = 0},

            };
        }
        public void Add(Post entity)
        {
            var newId = Posts.Max(i => i.Id) + 1;
            entity.Id = newId;
            Posts.Add(entity);
        }

        public void Delete(Post entity)
        {
            var post = GetById(entity.Id);
            Posts.Remove(post);
        }

        public List<Post> GetAll()
        {
            return Posts;
        }

        public Post GetById(int id)
        {
            return Posts.FirstOrDefault(i => i.Id == id);
        }

        public void IncrementViewedCount(int postId)
        {
            var data = GetById(postId);
            data.ViewedCount++;
        }

        public void Update(Post entity)
        {
            var post = GetById(entity.Id);
            post = entity;
        }
    }
}
