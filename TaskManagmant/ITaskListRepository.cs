using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public interface ITaskListRepository:IRepository<TaskList>
    {
        void AddNewTaskList(string title);
    }
}
