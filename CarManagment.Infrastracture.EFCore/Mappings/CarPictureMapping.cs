using CarManagment.Domain.CarAgg;
using CarManagment.Domain.CarPictureAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarManagment.Infrastracture.EFCore.Mappings
{
    public class CarPictureMapping : IEntityTypeConfiguration<CarPicture>
    {
        public void Configure(EntityTypeBuilder<CarPicture> builder)
        {
            builder.ToTable("CarPictures");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PictureAlt).HasMaxLength(500).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(500).IsRequired();

            builder.HasOne(x => x.Car).WithMany(x => x.CarPictures).HasForeignKey(x => x.CarId);
        }
    }
}
