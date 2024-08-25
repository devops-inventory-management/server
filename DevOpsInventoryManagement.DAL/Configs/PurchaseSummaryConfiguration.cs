using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevOpsInventoryManagement.DAL.Configs;

public class PurchaseSummaryConfiguration : IEntityTypeConfiguration<PurchaseSummary>
{
    public void Configure(EntityTypeBuilder<PurchaseSummary> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.TotalPurchased).IsRequired();
        builder.Property(p => p.ChangePercentage).IsRequired();
        builder.Property(p => p.Date).IsRequired();
    }
}
