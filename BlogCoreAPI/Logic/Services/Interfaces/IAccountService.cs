using DAL.Model;
using DAL.Model.LoginModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGIC.Services.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<User> GetUserOfAccount(int ID);
        User GetUserById(int id);
        void AddNewUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        int GetUserIDByEmail(string email);
        void Save();
        Task<string> Login(LoginModel model, HttpContext context);
        Task Logout(HttpContext context);
        User GetUserByEmail(string email);
    }
}
