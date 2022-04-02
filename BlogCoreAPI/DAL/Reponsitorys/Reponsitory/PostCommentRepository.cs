
using DAL.Model;
using DAL.Reponsitorys.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Reponsitorys.Reponsitory
{
    public class PostCommentRepository : BaseReponsitotyy<PostComment>, IPostCommentRepository
    {
        private ApContext _context = null;
        private DbSet<PostComment> table;
        public PostCommentRepository(ApContext dbcontext) : base(dbcontext)
        {
            this._context = dbcontext;
            table = _context.Set<PostComment>();
        }

        public IEnumerable<PostComment> GetCommentByCommentID(int comemntID)
        {
            return _context.PostComments.Where(a => a.ParentID == comemntID).ToList();
        }

        public IEnumerable<PostComment> GetCommentByPostID(int ID)
        {
            //ID in table PostComment 
            return _context.PostComments.Where(a => a.PostID == ID).ToList();
        }

        public IEnumerable<PostComment> GetCommentByPostIDUserID(int PostID, int UserID)
        {
            //ID in table PostComment is AuthorID, UserID in User
            return _context.PostComments.Where(a => a.PostID == PostID && a.UserID == UserID).ToList();
        }

    }
}
