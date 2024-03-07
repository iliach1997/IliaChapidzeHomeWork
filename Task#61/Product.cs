using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_61
{
    internal class Product : Item, IDiscountable
    {
        public int QuantityInStock {  get; set; }
        public ProductCategory ProductCategory { get; set; }
        public  decimal Discount { get; set; }
        public Product(string name,decimal price,int quantityinstock,decimal discount,ProductCategory productcategory):base(name,price)
        {
          QuantityInStock = quantityinstock;
          ProductCategory = productcategory;
          Discount = discount;
        }
        public override string GetProductInfo()
        {
            return Name;
        }
        public  decimal CalculateDiscountedPrice()
        {
            var discauntPrice =  Price - Discount;
            return discauntPrice;
        }
    }
}
