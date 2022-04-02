
using DAL.Model;
using DAL.Model.LoginModel;
using LOGIC.IUnitOfWorks;
using LOGIC.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGIC.Services.Service
{
    public class Usersevice : IUserSevice
    {
        private IUnitOfWork _IUnitofwork;
        public Usersevice(IUnitOfWork _unitOfWork)
        {
            this._IUnitofwork = _unitOfWork;
        }

        public void AddNewUser(User user)
        {
            this._IUnitofwork.user.Inser(user);
        }

        public void DeleteUser(int id)
        {
            this._IUnitofwork.user.Delete(id);
        }

        public IEnumerable<User> GetAllUser()
        {
            return (IEnumerable<User>)_IUnitofwork.user.GetAll();
        }

        public User GetUserById(int id)
        {
            return _IUnitofwork.user.GetByID(id);
        }

        public void UpdateUser(User user)
        {
            this._IUnitofwork.user.Update(user);
        }
        public void Save()
        {
            this._IUnitofwork.Save();
        }

        public Task<string> Login(LoginModel model, HttpContext context)
        {
            throw new NotImplementedException();
        }

        /* public User GetByLoginName(string email)
         {
             return _IUnitofwork.user.GetByLoginName(email);
         }*/
    }
}
