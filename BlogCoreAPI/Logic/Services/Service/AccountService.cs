

using DAL.Model;
using DAL.Model.LoginModel;
using DAL.Reponsitorys.Interfaces;
using LOGIC.IUnitOfWorks;
using LOGIC.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LOGIC.Services.Service
{
    public class AccountService : IAccountService
    {
        private IUnitOfWork IunitOfWork;
        public AccountService(IUnitOfWork _unitOfWork) => this.IunitOfWork = _unitOfWork;
        public void AddNewUser(User user)
        {
            this.IunitOfWork.user.Inser(user);
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            return IunitOfWork.user.GetAll().Where(a => a.Email == email).FirstOrDefault();
        }

        public User GetUserById(int id)
        {
            return IunitOfWork.user.GetAll().Where(a => a.UserID == id).SingleOrDefault();

        }

        public int GetUserIDByEmail(string email)
        {

            return IunitOfWork.user.GetAll().Where(a => a.Email == email).Select(a => a.UserID).SingleOrDefault();
        }

        public IEnumerable<User> GetUserOfAccount(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Login(LoginModel model, HttpContext context)
        {
            // string passwordHash = (model.Password);
            var user = await IunitOfWork.User.GetUser(model.Email, model.Password);
            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.Role, user.Role),
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
                    new AuthenticationProperties()
                    {
                        IsPersistent = model.RememberMe
                    });

                if (user.Role == "user")
                {
                    return "/Home/";
                }
                return "/Admin/";

            }
            else
            {
                return null;
            }
        }

        public async Task Logout(HttpContext context)
        {
            await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        }
        public void Save()
        {
            this.IunitOfWork.user.Save();
        }

        public void UpdateUser(User user)
        {
            this.IunitOfWork.user.Update(user);
        }
    }
}
