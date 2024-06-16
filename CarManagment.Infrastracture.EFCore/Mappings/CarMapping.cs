using CarManagment.Domain.CarAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogManagment.Infrastracture.EFCore.Mappings
{
    public class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CarName).HasMaxLength(500);
            builder.Property(x => x.Keywords).HasMaxLength(80).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(300).IsRequired();


            builder.HasMany(x => x.CarPictures).WithOne(x => x.Car).HasForeignKey(x => x.CarId);
            builder.HasOne(x => x.CarCategory).WithMany(x => x.Cars).HasForeignKey(x => x.CarCategoryId);
        }
    }
}
