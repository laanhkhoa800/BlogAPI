using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface ICommentRepository
    {
        IEnumerable<PostComment> GetAllUser();
        IEnumerable<PostComment> GetCommentById(int PostID);
        void AddNewComment(PostComment postComment);
        void UpdateComment(PostComment postComment);
        void DeleteComment(int id);
        void Save();
    }
}
