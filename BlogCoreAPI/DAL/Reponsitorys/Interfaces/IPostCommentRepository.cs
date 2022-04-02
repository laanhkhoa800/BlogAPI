using System;
using System.Collections.Generic;
using System.Text;
using DAL.Model;

namespace DAL.Reponsitorys.Interfaces
{
    public interface IPostCommentRepository : IBaseRepository<PostComment>
    {
        IEnumerable<PostComment> GetCommentByPostIDUserID(int PostID, int UserID);
        IEnumerable<PostComment> GetCommentByPostID(int ID);
        IEnumerable<PostComment> GetCommentByCommentID(int commentID);
    }
}
