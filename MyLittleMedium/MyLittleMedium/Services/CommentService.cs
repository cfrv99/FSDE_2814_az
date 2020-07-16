using MyLittleMedium.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleMedium.Services
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Delete(Comment comment);
        List<Comment> GetAll();
        List<Comment> GetCommentsByPost(int postId);
        Comment GetById(int id);
    }
    public class CommentService : ICommentService
    {
        private static List<Comment> Comments;

        static CommentService()
        {
            Comments = new List<Comment>
            {
                new Comment{Id=1,Text = "Ela postdu lezzet eledi",PostId=1},
                new Comment{Id=2,Text = "Ela postdu lezzet eledi",PostId=2},
                new Comment{Id=3,Text = "Ela postdu lezzet eledi",PostId=2},
                new Comment{Id=4,Text = "Ela postdu lezzet eledi",PostId=1},
                new Comment{Id=5,Text = "Ela postdu lezzet eledi",PostId=2},
            };
        }
        public void Add(Comment comment)
        {
            var newId = Comments.Max(i => i.Id) + 1;
            comment.Id = newId;
            Comments.Add(comment);
        }

        public void Delete(Comment comment)
        {
            var commentData = GetById(comment.Id);
            Comments.Remove(commentData);
        }

        public List<Comment> GetAll()
        {
            return Comments;
        }

        public Comment GetById(int id)
        {
            return Comments.FirstOrDefault(i => i.Id == id);
        }

        public List<Comment> GetCommentsByPost(int postId)
        {
            var comments = Comments.Where(i => i.PostId == postId).ToList();
            return comments;
        }
    }
}
