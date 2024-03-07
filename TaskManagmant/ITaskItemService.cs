using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public interface ITaskItemService
    {
        TaskItem getById(int id);
        void Add(string title, string desqription, bool isCompleted, DateTime dateTime);
        void delete(int id);
        ICollection<TaskItem> GetAll();
        void Update(int taskId);
        void PrintIsCompletTask();
        void PrintUnfulfilledTask();
    }
}
