using BlogManagment.Domain.BlogAgg;
using BlogManagment.Infrastracture.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;

namespace BlogManagment.Infrastracture.EFCore
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(BlogMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
