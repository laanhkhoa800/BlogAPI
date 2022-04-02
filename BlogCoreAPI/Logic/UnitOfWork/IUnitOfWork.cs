
using DAL.Model;
using DAL.Reponsitorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGIC.IUnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<User> user { get; }
        IBaseRepository<Post> post { get; }
        IUserRepository User { get; }
        void Save();
    }
}
