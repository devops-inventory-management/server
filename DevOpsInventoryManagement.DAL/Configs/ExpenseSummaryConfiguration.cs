using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevOpsInventoryManagement.DAL.Configs;

public class ExpenseSummaryConfiguration : IEntityTypeConfiguration<ExpenseSummary>
{
    public void Configure(EntityTypeBuilder<ExpenseSummary> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.TotalExpenses).IsRequired();
        builder.Property(e => e.Date).IsRequired();
    }
}
