using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PostBlog.DataAcces;
using PostBlog.Services;
using System;

namespace PostBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<IPostService, PostService>();
            builder.Services.AddDbContext<PostDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("PostConnection")));
            var app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Blog}/{action=Index}/{id?}");

            app.Run();
        }
    }
}