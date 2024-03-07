using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarService
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> categories = new List<Category>() { 
           new Category{Id=1,Name="Phone"},
           new Category{Id=2,Name="Leptop",Product=new Product()}

        };
        public void Add(Category item)
        {
            categories.Add(item);
        }

        public void Delete(int id)
        {
          var item=  categories.FirstOrDefault(x => x.Id == id);
           categories.Remove(item);
        }

        public IEnumerable<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            var item = categories.FirstOrDefault(x => x.Id == id);
            return item;
        }

        public void Update(Category item)
        {
           var upDateItem=categories.FirstOrDefault(x=>x.Id==item.Id);
            categories[upDateItem.Id]=item;
        }
    }
}
