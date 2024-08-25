using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevOpsInventoryManagement.DAL.Configs;

public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
{
    public void Configure(EntityTypeBuilder<Expense> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Category).IsRequired();
        builder.Property(e => e.Amount).IsRequired();
        builder.Property(e => e.Date).IsRequired();
    }
}
