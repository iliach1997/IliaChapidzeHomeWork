using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_61
{
    internal class DiscountedProduct : Product,IDiscountable
    {
        public DiscountedProduct(string name, decimal price, int quantityinstock, decimal discount, ProductCategory productcategory) : base(name, price, quantityinstock, discount, productcategory)
        {
        }
        public override string GetProductInfo()
        {
            CalculateDiscountedPrice();
            return base.GetProductInfo();
        }
    }
}
