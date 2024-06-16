using BlogManagment.Infrastracture.Configuration;
using CarManagment.Infrastracture.Configuration;
using CommentManagement.Infrastructure.Configuration;

namespace CarAnalysis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionString = builder.Configuration.GetConnectionString("CarAnalysisDb");
            CarBootstraper.Configure(builder.Services, connectionString);
            BlogBootstraper.Configure(builder.Services, connectionString);
            CommentBootstrapper.Configure(builder.Services, connectionString);

            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}