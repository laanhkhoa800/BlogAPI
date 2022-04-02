
using DAL.Reponsitorys.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Reponsitorys.Reponsitory
{
    public class BaseReponsitotyy<T> : IBaseRepository<T> where T : class
    {
        protected ApContext Context { get; private set; }
        /*       private AppContext Context = null;*/
        private DbSet<T> _table = null;
        public BaseReponsitotyy(ApContext dbcontext)
        {
            this.Context = dbcontext;
            _table = Context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }
        public T GetByID(int ID)
        {
            return _table.Find(ID);
        }

        public void Inser(T obj)
        {
            _table.Add(obj);
        }
        public void Update(T obj)
        {
            _table.Attach(obj);
            Context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(int ID)
        {
            T Exis = _table.Find(ID);
            _table.Remove(Exis);
        }
        public void Save()
        {
            Context.SaveChanges();
        }

        public T Search(string a)
        {
            return _table.Find(a);
        }
    }
}
