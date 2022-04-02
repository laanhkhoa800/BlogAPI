using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface IPostCommentService
    {
        IEnumerable<PostComment> GetAllPostCommentByPostID(int PostID);

        void AddComment(PostComment postComment);
        void AddSubComment(PostComment postComment);
        IEnumerable<PostComment> FindSubCommentInComment(int commentID);
        void DeleteComment(int CommentID);
        void Save();

    }
}
