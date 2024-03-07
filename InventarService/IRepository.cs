using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarService
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Delete(int id);
        void Update(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
