using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _repository = categoryRepository;
        }
        public void Add(Category category)
        {
            _repository.Add(category);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            var result= _repository.GetAll();
            return result;
        }

        public Category GetByID(int id)
        {
            var result= _repository.GetById(id);
            return result;
        }

        public void Update(Category category)
        {
            _repository.Update(category);
        }
    }
}
