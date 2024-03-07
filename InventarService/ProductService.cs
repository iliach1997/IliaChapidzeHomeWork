using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarService
{
    public class ProductService : IProductService
    {
        private readonly IProductRrepository _repository;
        public  ProductService(IProductRrepository productRrepository)
        {
            _repository = productRrepository;
        }
        public void Add(Product product)
        {
            _repository.Add(product);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
           var product= _repository.GetAll();
            return product;
        }

        public Product GetByID(int id)
        {
          var product= _repository.GetById(id);
            return product;
        }

        public void getByCategoryName(string name)
        {
            _repository.getByCategoryName(name);

        }

        public void Update(Product product)
        {
            _repository.Update(product);
        }

        public void Sale(Product product, int Quantity)
        {
            _repository.Sale(product,Quantity);
        }
    }
}
