using Microsoft.EntityFrameworkCore;
using Task_NET_09.Repository;

namespace Task_NET_09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MyDbContext>(x =>x.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
           // builder.Services.AddScoped<IToDoItemsCervice,ToDoItemsCervice>();
            builder.Services.AddTransient<IToDoRepository,ToDoRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=ToDoItems}/{action=Index}/{id?}");
               
          //   builder.Services.AddDbContext<MyDbContext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
            app.Run();
        }
    }
}
