using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public interface ITaskItemRepository:IRepository<TaskItem>
    {
        void AddNewTaskDataBase(string title, string desqription, bool isCompleted, DateTime dateTime);
        void Update(int taskId);
        void PrintIsCompletTask();
        void PrintUnfulfilledTask();
    }
}
