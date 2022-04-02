using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface IPostService
    {
        IEnumerable<Post> GetAllPost();
        IEnumerable<Post> GetPostOfUserID(int ID);
        Post GetPostById(int id);
        void AddNewPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int id);
        void Save();
        IEnumerable<Post> Search(string a, int ID);
        IEnumerable<Post> SearchHomePage(string a);

    }
}
