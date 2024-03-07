using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarService
{
    public interface IProductRrepository:IRepository<Product>
    {
        public void Sale(Product product, int Quantity);
        public void getByCategoryName(string name);
        public void Discount(Product product);
    }
}
