using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevOpsInventoryManagement.DAL.Configs;

public class ExpenseByCategoryConfiguration : IEntityTypeConfiguration<ExpenseByCategory>
{
    public void Configure(EntityTypeBuilder<ExpenseByCategory> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Date).IsRequired();
        builder.Property(e => e.Category).IsRequired();
        builder.Property(e => e.Amount).IsRequired();
    }
}
