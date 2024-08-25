using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevOpsInventoryManagement.DAL.Configs;

public class SaleSummaryConfiguration : IEntityTypeConfiguration<SaleSummary>
{
    public void Configure(EntityTypeBuilder<SaleSummary> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.TotalValue).IsRequired();
        builder.Property(s => s.ChangePercentage).IsRequired();
        builder.Property(s => s.Date).IsRequired();
    }
}
