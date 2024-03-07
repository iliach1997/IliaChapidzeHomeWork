
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InventarService
{
    public class ProductRrepository:IProductRrepository
    {

        public List<Product> products = new List<Product>() { };
     

        public void Add(Product item)
        {
           products.Add(item);
           // Console.WriteLine($"{item.Id}{item.Name}{item.Description}{item.Category.Name}");
        }

        public void Delete(int id)
        { 
          var item=products.FirstOrDefault(x => x.Id == id);
          products.Remove(item);
        }

        public IEnumerable<Product> GetAll()
        {
           foreach(var item in products)
           {
                Console.WriteLine($"Id:{item.Id} Name{item.Name} Description:{item.Description} Category Name:{item.Category.Name} Quantity:{item.Quantity}");
           }
           return products;
        }

        public Product GetById(int id)
        {
            var item = products.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public void Sale(Product item, int Quantity)
        {
            var product = products.FirstOrDefault(x => x.Id == item.Id);
     
            if(item.Quantity > Quantity)
            {
                item.Quantity =item.Quantity-Quantity;
                
                Console.WriteLine("nivti gaiyida");
            }
            Console.WriteLine("maragi amoiwura");

        }

        public void Update(Product item)
        {
            var product = products.FirstOrDefault(x => x.Id == item.Id);
            products[product.Id]= item;
        }
        public void getByCategoryName(string name) {
            var pro = products.Where(x => x.Category.Name == name);
            foreach(var item in pro)
            { 
                Console.WriteLine($"{item.Id}{item.Name}{item.Description}{item.Category.Name}");

            }
          
            
        }

        public void Discount(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
