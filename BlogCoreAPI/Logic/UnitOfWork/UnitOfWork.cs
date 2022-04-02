
using DAL.Model;
using DAL.Reponsitorys;
using DAL.Reponsitorys.Interfaces;
using DAL.Reponsitorys.Reponsitory;
using LOGIC.IUnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Dependence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private UserRepository _userRepository;
        private ApContext dataContext;
        public UnitOfWork(ApContext conText)
        {
            dataContext = conText;
            user = new BaseReponsitotyy<User>(conText);
            post = new BaseReponsitotyy<Post>(conText);
            User = new UserRepository(dataContext);
        }

        private bool disposed = false;

        public IBaseRepository<User> user { get; set; }

        public IBaseRepository<Post> post { get; set; }

        public IUserRepository User { get; }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dataContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



        void IUnitOfWork.Save()
        {
            dataContext.SaveChanges();
        }
    }
}
