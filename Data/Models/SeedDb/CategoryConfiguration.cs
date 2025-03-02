using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Data.Models.SeedDb
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category> 
    {
        public void Configure(EntityTypeBuilder <Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[] { data.DuplexCategory, data.SingleCategory, data.CottageCategory });
        }
    }
}
