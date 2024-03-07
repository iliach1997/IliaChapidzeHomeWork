using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarService
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
        Category GetByID(int id);
        IEnumerable<Category> GetAll();
    }
}
