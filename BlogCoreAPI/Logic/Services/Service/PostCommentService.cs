
using DAL.Model;
using DAL.Reponsitorys.Interfaces;
using LOGIC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGIC.Services.Service
{
    public class PostCommentService : IPostCommentService
    {
        private readonly bool disposed = false;
        private IPostCommentRepository _IpostCommentRepository;
        //private IUnitOfWork _IUnitofwork;
        public PostCommentService(IPostCommentRepository postCommentRepository)
        {
            this._IpostCommentRepository = postCommentRepository;
        }

        public void AddComment(PostComment postComment)
        {
            _IpostCommentRepository.Inser(postComment);
        }

        public void AddSubComment(PostComment postComment)
        {
            _IpostCommentRepository.Inser(postComment);
        }

        public void DeleteComment(int CommentID)
        {
            _IpostCommentRepository.Delete(CommentID);
        }

        public IEnumerable<PostComment> FindSubCommentInComment(int commentID)
        {
            return _IpostCommentRepository.GetCommentByCommentID(commentID);
        }

        public IEnumerable<PostComment> GetAllPostCommentByPostID(int PostID)
        {
            return _IpostCommentRepository.GetAll().Where(item => item.PostID == PostID);
        }

        public void Save()
        {
            _IpostCommentRepository.Save();
        }
    }
}
