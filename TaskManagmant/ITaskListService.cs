using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public interface ITaskListService
    {
        TaskList getById(int id);
        void Add(string title);
        void delete(int id);
        ICollection<TaskList> GetAll();
    }
}
