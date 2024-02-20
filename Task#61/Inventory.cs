using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_61
{
    internal class Inventory
    {
         List<Product>listitem=new List<Product>();
         public void add(Product product)
         {
            listitem.Add(product);
         }
         public Product GetById(int id)
         {
          return listitem[id];
         }
       
    }
}
