
using DAL.Model;
using LOGIC.IUnitOfWorks;
using LOGIC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGIC.Services.Service
{
    public class PostService : IPostService
    {
        private IUnitOfWork _IUnitOfWork;
        public PostService(IUnitOfWork unitOfWork)
        {
            _IUnitOfWork = unitOfWork;
        }

        public void AddNewPost(Post post)
        {
            this._IUnitOfWork.post.Inser(post);
            //this.IunitOfWork.post.Save();
        }

        public void DeletePost(int id)
        {
            this._IUnitOfWork.post.Delete(id);
        }

        public IEnumerable<Post> GetAllPost()
        {
            return _IUnitOfWork.post.GetAll().ToList();
        }

        public Post GetPostById(int id)
        {
            return _IUnitOfWork.post.GetByID(id);
        }

        public void UpdatePost(Post post)
        {
            this._IUnitOfWork.post.Update(post);
        }
        public void Save()
        {
            this._IUnitOfWork.post.Save();
        }

        public IEnumerable<Post> GetPostOfUserID(int ID)
        {
            return _IUnitOfWork.post.GetAll().Where(a => a.AuthorID == ID);
        }

        public IEnumerable<Post> Search(string a, int ID)
        {
            return _IUnitOfWork.post.GetAll().Where(s => s.Title.StartsWith(a) && s.AuthorID == ID);
        }
        public IEnumerable<Post> SearchHomePage(string a)
        {
            return _IUnitOfWork.post.GetAll().Where(s => s.Title.StartsWith(a));
        }
    }
}
