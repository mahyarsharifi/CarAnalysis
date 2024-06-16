using CarManagment.Domain.CategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagment.Infrastracture.EFCore.Mappings
{
    public class CarCategoryMapping : IEntityTypeConfiguration<CarCategory>
    {
        public void Configure(EntityTypeBuilder<CarCategory> builder)
        {
            builder.ToTable("CarCategories");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.PictureAlt).HasMaxLength(255);
            builder.Property(x => x.PictureTitle).HasMaxLength(500);
            builder.Property(x => x.Keywords).HasMaxLength(80).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(300).IsRequired();

            builder.HasMany(x => x.Cars).WithOne(x => x.CarCategory).HasForeignKey(x => x.CarCategoryId);
        }
    }
}
