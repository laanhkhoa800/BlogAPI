
using DAL.Model;
using LOGIC.IUnitOfWorks;
using LOGIC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreAPI.Dependence.Services
{
    public class CommentsService : ICommentRepository
    {
        private IUnitOfWork _IUnitofwork;
        public CommentsService(IUnitOfWork _unitOfWork)
        {
            this._IUnitofwork = _unitOfWork;
        }
        public void AddNewComment(PostComment postComment)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int id)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<PostComment> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostComment> GetCommentById(int PostID)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(PostComment postComment)
        {
            throw new NotImplementedException();
        }
    }
}
