using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaskManagmant.TaskItem;

namespace TaskManagmant
{
    public class TaskItemRepository : ITaskItemRepository
    {
        public void AddNewTaskDataBase(string title, string desqription, bool isCompleted, DateTime _dateTime)
        {
            using var context = new MyDbContext();
            var taskItem = new TaskItem()
            {
                Title = title,
                Description = desqription,
                IsCompleted = isCompleted,
                dateTime = _dateTime,
              

            };
            var Tasklist = new TaskList()
            {
                Title = title,
                TaskItem = new List<TaskItem> { taskItem }
            };
            context.TaskLists.Add(Tasklist);
            context.SaveChanges();
            Console.WriteLine("Add TaskItem To NewDataBaseForTaskItem");
        }
        public void Delete(int id)
        {
           using var context= new MyDbContext();
           var tsakItem=context.TaskItems.FirstOrDefault(x=>x.Id==id);
           context.TaskItems.Remove(tsakItem);
        }

        public ICollection<TaskItem> GetAll()
        {
            using var context=new MyDbContext();
            var tastItem = context.TaskItems.Include(x => x.TaskList).Where(x => x.Id < x.Id + 1);
            Console.WriteLine("***********************************************TaskItems********************************************************");
            foreach (var task in tastItem)
            {
                Console.WriteLine($"ID:{task.Id} Title:{task.Title} Description:{task.Description} IsCompleted:{task.IsCompleted} DateTime:{task.dateTime}");
            }
            return tastItem.ToList();
        }
        public TaskItem GetById(int id)
        {
            using var context = new MyDbContext();
            var task = context.TaskItems.FirstOrDefault(x => x.Id == id);
            Console.WriteLine($"Id:{id} Title:{task.Title} Description:{task.Description} IsCompleted:{task.IsCompleted} DateTime:{task.dateTime}");
            return task;
        }
        public void Update(int taskId)
        {
            using var context = new MyDbContext();
            var task = context.TaskItems.Include(x => x.TaskList).FirstOrDefault(x => x.TaskItemId == taskId);
            task.IsCompleted = true;
          
            var Tasklist = new TaskList()
            {

                Title = task.Title,
                TaskItem = new List<TaskItem> { task }
            };
       
            context.TaskLists.Add(Tasklist);
            context.SaveChanges();
            Console.WriteLine($"{task.Id} {task.Title}{task.IsCompleted}");
           
        }   
        public void PrintIsCompletTask()
        {
            using var context = new MyDbContext();
            Console.WriteLine("Completed tasks");
            var tastItemcompleted = context.TaskItems.Include(x => x.TaskList).Where(x => x.IsCompleted==true);
            foreach (var item in tastItemcompleted)
            {
                Console.WriteLine($"Id:{item.Id} Title:{item.Title} Description:{item.Description} IsCompleted:{item.IsCompleted} DateTime:{item.dateTime}");
            }
        }
        public void PrintUnfulfilledTask()
        {
            using var context = new MyDbContext();
            Console.WriteLine("unfulfilled tasks:");
            var unfulfilled = context.TaskItems.Include(x => x.TaskList).Where(x => x.IsCompleted == false);
            foreach (var item in unfulfilled)
            {
                Console.WriteLine($"Id:{item.Id} Title:{item.Title} Description:{item.Description} IsCompleted:{item.IsCompleted} DateTime:{item.dateTime}");
            }
        }
    }
}
