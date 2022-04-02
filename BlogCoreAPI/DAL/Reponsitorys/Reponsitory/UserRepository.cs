using DAL.Model;
using DAL.Reponsitorys.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reponsitorys.Reponsitory
{
    public class UserRepository : BaseReponsitotyy<User>, IUserRepository
    {
        protected ApContext _context { get; private set; }
        private DbSet<User> table;
        public UserRepository(ApContext dbcontext) : base(dbcontext)
        {
            this._context = dbcontext;
            table = _context.Set<User>();
        }

        public async Task<User> GetUser(string email, string password)
        {
            var user = _context.User.Where(u => u.Email == email && u.PassWord == password).FirstOrDefault();
            return user;
        }
    }
}
