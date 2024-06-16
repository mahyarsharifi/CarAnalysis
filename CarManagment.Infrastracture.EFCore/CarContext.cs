using BlogManagment.Infrastracture.EFCore.Mappings;
using CarManagment.Domain.CarAgg;
using CarManagment.Domain.CarPictureAgg;
using CarManagment.Domain.CategoryAgg;
using Microsoft.EntityFrameworkCore;

namespace CarManagment.Infrastracture.EFCore
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<CarPicture> CarPictures { get; set; }

        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(CarMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
