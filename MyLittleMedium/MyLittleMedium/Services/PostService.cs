using MyLittleMedium.Entities;
using MyLittleMedium.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleMedium.Services
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
                new Post{Id=1,Name="Asp.Net Core",Desc="Asp.Net Core the best",ViewedCount=0},
                new Post{Id=2,Name="PHP",Desc="PHP the best",ViewedCount=0},
                new Post{Id=3,Name="Django",Desc="Django the best",ViewedCount=0},
                new Post{Id=4,Name="SpringBoot",Desc="SpringBoot the best",ViewedCount=0}
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
            var posts = Posts;
            return posts;
        }

        public Post GetById(int id)
        {
            var post = Posts.FirstOrDefault(i => i.Id == id);
            return post;
        }

        public void IncrementViewedCount(int postId)
        {
            var post = GetById(postId);
            post.ViewedCount++;
        }

        public void Update(Post entity)
        {
            if(entity.Id<=0){
                throw new RestExceptions(System.Net.HttpStatusCode.BadRequest, "Id can not be null");
            }
            var data = GetById(entity.Id);
            data = entity;
        }
    }
}
