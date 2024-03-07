using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagmant
{
    public class MyDbContext: DbContext
    {
        public DbSet<TaskList> TaskLists { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-KHBJU5S\MSSQLSERVER2024;Initial Catalog=NewDataBaseForTaskItem;Integrated Security=True;MultipleActiveResultSets=True;Encrypt=false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<TaskItem>()
                .HasOne(x => x.TaskList)
                .WithMany(x => x.TaskItem)
                .HasForeignKey(x => x.TaskItemId);
        }
    }
}
