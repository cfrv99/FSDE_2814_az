using LittleBlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBlogApp.Services
{
    public interface ICommentService
    {
        void Add(Comments entity);
        void Delete(Comments entity);
        List<Comments> GetAll();
        Comments GetById(int id);
        List<Comments> GetCommentsByPostId(int postId);
    }
    public class CommentService : ICommentService
    {
        private static List<Comments> Comments;
        static CommentService()
        {
            Comments = new List<Comments>
            {
                new Comments {Id=1,Text="Ela lezet eledi",PostId = 1},
                new Comments {Id=2,Text="Ela lezet eledi",PostId = 1},
                new Comments {Id=3,Text="Ela lezet eledi",PostId = 1},
                new Comments {Id=4,Text="Ela lezet eledi",PostId = 1}
            };
        }

        public void Add(Comments entity)
        {
            var newId = Comments.Max(i => i.Id) + 1;
            entity.Id = newId;
            Comments.Add(entity);
        }

        public void Delete(Comments entity)
        {
            var comment = GetById(entity.Id);
            Comments.Remove(comment);
        }

        public List<Comments> GetAll()
        {
            return Comments;
        }

        public Comments GetById(int id)
        {
            return Comments.FirstOrDefault(i => i.Id == id);
        }

        public List<Comments> GetCommentsByPostId(int postId)
        {
            return Comments.Where(i => i.PostId == postId).ToList();
        }
    }
}
