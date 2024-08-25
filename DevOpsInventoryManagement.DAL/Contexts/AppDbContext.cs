using DevOpsInventoryManagement.DAL.Configs;
using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevOpsInventoryManagement.DAL.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<ExpenseByCategory> ExpensesByCategory { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<PurchaseSummary> PurchaseSummaries { get; set; }
    public DbSet<SaleSummary> SaleSummaries { get; set; }
    public DbSet<ExpenseSummary> ExpenseSummaries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new ExpenseByCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseConfiguration());
        modelBuilder.ApplyConfiguration(new SaleConfiguration());
        modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseSummaryConfiguration());
        modelBuilder.ApplyConfiguration(new SaleSummaryConfiguration());
        modelBuilder.ApplyConfiguration(new ExpenseSummaryConfiguration());
    }
}
