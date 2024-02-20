using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public class TaskList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<TaskItem> TaskItem { get; set; }
    }
}
