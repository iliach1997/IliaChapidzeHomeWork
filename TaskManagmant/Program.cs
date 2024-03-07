using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TaskManagmant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taskListRepository = new TaskListRepository();
            var taskListservice = new TaskListService(taskListRepository);
            var taskItemRepository =new TaskItemRepository();
            var taskItemService=new TaskItemService(taskItemRepository);
            Console.WriteLine("" +
                 "Helow This is a task management system To add to the tasklist\r\nIn the console, Enter: add If you want to add " +
                 "taskItem, enter additem, Enter the following commands to work with the TaskList data:id," +
                 " getall, delete.Enter the following commands to work with the TaskIist data:getalltaskitem,getbyiditem,update,iscomplet,unfulfilled"+
                 "Enter Your Comand:"
                 );
            string command = Console.ReadLine();
            switch (command)
            {
                
                case "add":
                    Console.WriteLine("enter TaskList Title");
                    var title=Console.ReadLine();
                    taskListservice.Add(title);
                break;
                case "IsComplet":
                    taskItemService.PrintIsCompletTask();
                    break;
                case "unfulfilled":
                    taskItemService.PrintUnfulfilledTask();
                    break;
                case "update":
                    Console.WriteLine("Enter Id:");
                    var taskId = Convert.ToInt32(Console.ReadLine());
                    taskItemService.Update(taskId);
                    break;
                case "id":
                    Console.WriteLine("Enter Id:");
                    var id=Convert.ToInt32(Console.ReadLine());
                    taskListservice.getById(id);
                    break;
                case "getall":
                    taskListservice.GetAll();
                    break;
                case "getbyiditem":
                    Console.WriteLine("Enter Id:");
                    var taskItemId=Convert.ToInt32(Console.ReadLine());
                    taskItemService.getById(taskItemId);
                    break;
                case "getalltaskitem":
                    taskItemService.GetAll();
                    break;
                case "delete":
                    Console.WriteLine("Enter Id:");
                    var deleteid=Convert.ToInt32(Console.ReadLine());
                    taskListservice.delete(deleteid);
                    break;
                case "additem":
                    Console.WriteLine("Enter TaskItem Title:");
                    var taskitemtitle = Console.ReadLine();
                    Console.WriteLine("Enter TaskItem Description:");
                    var description=Console.ReadLine();
                    Console.WriteLine("Enter TaskItem IsCompleted true or false");
                    var isCompleted=Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Enter TaskItem DateTime:");
                    var dataTime=Convert.ToDateTime(Console.ReadLine());
                    taskItemService.Add(taskitemtitle, description, isCompleted, dataTime);
                break;
                default: Console.WriteLine("Invalid command");
                break;
            }
        }
    }
}
