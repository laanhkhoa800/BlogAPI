using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Reponsitorys.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetUser(string email, string password);
    }
}
