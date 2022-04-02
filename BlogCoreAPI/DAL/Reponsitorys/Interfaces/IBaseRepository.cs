using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Reponsitorys.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int ID);
        void Inser(T obj);
        void Delete(int ID);
        void Update(T obj);
        void Save();
        T Search(string a);
    }
}
