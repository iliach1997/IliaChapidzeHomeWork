using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public class TaskListRepository: ITaskListRepository
    {
        public void AddNewTaskList(string title)
        {
            using var context = new MyDbContext();
            var TaskList = new TaskList()
            {
                Title = title,
            };
            context.TaskLists.Add(TaskList);
            context.SaveChanges();
            Console.WriteLine("Add TaskList To NewDataBaseForTaskItem");
        }
        public void Delete(int id)
        {
            using var context = new MyDbContext();
            var tasklist = context.TaskLists.FirstOrDefault(x => x.Id == id);
            context.TaskLists.Remove(tasklist);
            context.SaveChanges();
            Console.WriteLine("taskList delete");
        }
        public  ICollection<TaskList> GetAll()
        {
            using var context = new MyDbContext();
            var tasklist = context.TaskLists.Include(x => x.TaskItem).Where(x => x.Id < x.Id + 1);
            Console.WriteLine("*************TaskList************");
            foreach (var task in tasklist)
            {
                Console.WriteLine($"{task.Id} {task.Title}");
            }

            return tasklist.ToList();
        }
        public TaskList GetById(int id)
        {
            using var context = new MyDbContext();
            var tasklist = context.TaskLists.FirstOrDefault(x => x.Id == id);
            Console.WriteLine($"Title:{tasklist.Title} Id:{tasklist.Id}");
            return tasklist;
        }
    }
}
