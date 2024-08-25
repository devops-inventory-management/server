using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.DAL.Fixtures;

public class SeedData
{
    public List<Product> Products { get; set; } = [];
    public List<User> Users { get; set; } = [];
    public List<ExpenseByCategory> ExpensesByCategory { get; set; } = [];
    public List<Expense> Expenses { get; set; } = [];
    public List<Purchase> Purchases { get; set; } = [];
    public List<Sale> Sales { get; set; } = [];
    public List<PurchaseSummary> PurchaseSummaries { get; set; } = [];
    public List<SaleSummary> SaleSummaries { get; set; } = [];
    public List<ExpenseSummary> ExpenseSummaries { get; set; } = [];
}
