using Task_NET_09.DbContextModels;
using Task_NET_09.Models;

namespace Task_NET_09.Repository
{
    public interface IToDoRepository
    {
        IEnumerable<GetToDuItemViewModel> GetAll();
        void Insert(GetToDuItemViewModel item);
        ToDoItems GetById(int id);
        void Update(GetToDuItemViewModel item);
        void DeleteById(int id);
        void Save();
    }
}
