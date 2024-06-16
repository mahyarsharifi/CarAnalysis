using _01_CarAnalysisQuery.Contracts.Blog;
using _01_CarAnalysisQuery.Query;
using BlogManagment.Application;
using BlogManagment.Application.Contracts.Blog;
using BlogManagment.Domain.BlogAgg;
using BlogManagment.Infrastracture.EFCore;
using BlogManagment.Infrastracture.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlogManagment.Infrastracture.Configuration
{
    public class BlogBootstraper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {

            services.AddTransient<IBlogApplication, BlogApplication>();
            services.AddTransient<IBlogRepository, BlogRepository>();

            services.AddTransient<IBlogQuery, BlogQuery>();

            services.AddDbContext<BlogContext>(x => x.UseSqlServer(connectionString));
        }
    }
}