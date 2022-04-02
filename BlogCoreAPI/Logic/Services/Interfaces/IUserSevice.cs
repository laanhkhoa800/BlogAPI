using DAL.Model;
using DAL.Model.LoginModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface IUserSevice
    {
        IEnumerable<User> GetAllUser();
        User GetUserById(int id);
        void AddNewUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        void Save();
        Task<string> Login(LoginModel model, HttpContext context);
    }
}
