using Microsoft.EntityFrameworkCore;
using Task_NET_09.DbContextModels;

namespace Task_NET_09
{
    public class MyDbContext: DbContext
    {

 
        //public MyDbContext() { }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    
        public  DbSet<ToDoItems> ToDoItems { get; set; }

    }
}
