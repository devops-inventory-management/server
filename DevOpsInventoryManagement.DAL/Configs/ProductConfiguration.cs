using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevOpsInventoryManagement.DAL.Configs;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

        builder.Property(p => p.Price).HasColumnType("decimal(10, 2)");

        builder.Property(p => p.Rating).HasColumnType("decimal(2, 1)");

        builder.Property(p => p.StockQuantity).IsRequired();

        builder.Property(p => p.Description).HasMaxLength(500);
    }
}
