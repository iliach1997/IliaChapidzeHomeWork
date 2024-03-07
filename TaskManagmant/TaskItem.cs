using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime dateTime { get; set; }
        public bool IsCompleted { get; set; }
        public int TaskItemId {  get; set; }
        public enum TaskItemType
        {
           Low=1, Medium=2, High=3
        }
        public TaskList TaskList { get; set; }
    }
}
