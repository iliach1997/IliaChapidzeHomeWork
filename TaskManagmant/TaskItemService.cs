using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public class TaskItemService : ITaskItemService
    {
        private readonly ITaskItemRepository _taskItemRepository;
        public TaskItemService( ITaskItemRepository taskItemRepository )
        {
            _taskItemRepository = taskItemRepository;
        }

        public void Add(string title, string desqription, bool isCompleted, DateTime dateTime)
        {
            _taskItemRepository.AddNewTaskDataBase(title,desqription,isCompleted, dateTime );
        }

        public void delete(int id)
        {
            _taskItemRepository.Delete(id);
        }

        public ICollection<TaskItem> GetAll()
        {
            var taskItem= _taskItemRepository.GetAll();
            return taskItem;
        }

        public TaskItem getById(int id)
        {
            var taskItem=_taskItemRepository.GetById(id);
            return taskItem;
        }

        public void PrintIsCompletTask()
        {
           _taskItemRepository.PrintIsCompletTask();
        }

        public void PrintUnfulfilledTask()
        {
            _taskItemRepository.PrintUnfulfilledTask();
        }

        public void Update(int taskId)
        {
            _taskItemRepository.Update(taskId);
        }
    }
}
