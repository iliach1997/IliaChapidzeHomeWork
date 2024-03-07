using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public class TaskListService:ITaskListService
    {
        private readonly ITaskListRepository _taskListRepository;
        public TaskListService(ITaskListRepository taskListRepository) {
            _taskListRepository = taskListRepository;
        }

        public void Add(string title)
        {
            _taskListRepository.AddNewTaskList(title);
        }

        public void delete(int id)
        {
           _taskListRepository.Delete(id);
        }

        public ICollection<TaskList> GetAll()
        {
            var resultTaskList=_taskListRepository.GetAll();
            return resultTaskList;
        }

        public TaskList getById(int id)
        {
            var resultTaskList = _taskListRepository.GetById(id);
            return resultTaskList;
        }
        public void PrintTaskList()
        {
            var tasklist=_taskListRepository.GetAll();
            foreach (var task in tasklist)
            {
                Console.WriteLine(task.Title);
            }
        }
    }
}
