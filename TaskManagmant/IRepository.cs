using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public interface IRepository<T>where T : class
    { 
        void Delete(int id);
        ICollection<T> GetAll();
        T GetById(int id);
    }
}
