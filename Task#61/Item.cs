using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_61
{
    internal class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual string GetProductInfo()
        {
            return $"{Name} {Price}";
        }
        public Item(string name,decimal price)
        { 
            Name = name ;
            Price = price ;
        }
    }
}
