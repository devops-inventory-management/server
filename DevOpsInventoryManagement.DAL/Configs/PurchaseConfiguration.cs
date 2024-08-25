using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevOpsInventoryManagement.DAL.Configs;

public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
{
    public void Configure(EntityTypeBuilder<Purchase> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.PurchaseDate).IsRequired();
        builder.Property(p => p.ProductId).IsRequired();
        builder.Property(p => p.Quantity).IsRequired();
        builder.Property(p => p.UnitCost).IsRequired();
        builder.Property(p => p.TotalCost).IsRequired();
    }
}
