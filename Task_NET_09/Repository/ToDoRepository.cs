using Task_NET_09.DbContextModels;
using Task_NET_09.Models;

namespace Task_NET_09.Repository
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly MyDbContext _context;
        public ToDoRepository(MyDbContext context) { 
         _context = context;
        }
        public void DeleteById(int id)
        {
            var toDoItemsId=_context.ToDoItems.FirstOrDefault(x => x.Id == id);
            if (toDoItemsId != null)
            {
                _context.ToDoItems.Remove(toDoItemsId);
            }
        }

        public IEnumerable<GetToDuItemViewModel> GetAll()
        {
            var allItem=_context.ToDoItems;
            var viewModel = allItem.Select(x => new GetToDuItemViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                IsComplete = x.IsComplete,
            });
            return viewModel;
        }

        public ToDoItems GetById(int id)
        {
            var toDoItemsId = _context.ToDoItems.Find(id);
            return toDoItemsId;
        }

        public void Insert(GetToDuItemViewModel item)
        {
            var viewModel=new ToDoItems()
            {
                Id= item.Id,
                Name= item.Name,
                IsComplete= item.IsComplete,
            };
           _context.ToDoItems.Add(viewModel);
        }

        public void Save()
        {
          _context.SaveChanges();
        }

        public void Update(GetToDuItemViewModel item)
        {
          var toDoItemInDb=_context.ToDoItems.Find( item.Id);
            toDoItemInDb.Name= item.Name;
            toDoItemInDb.IsComplete= item.IsComplete;
          
        }
    }
}
