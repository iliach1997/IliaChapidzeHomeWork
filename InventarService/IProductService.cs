using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarService
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        Product GetByID(int id);
        void getByCategoryName(string name);
        void Sale(Product product, int Quantity);
        //void Discount(P)
        IEnumerable<Product> GetAll();
        void Delete(int id);

    }
}
