using System.Reflection;
using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DevOpsInventoryManagement.DAL.Fixtures;

public class DbSeeder
{
    private readonly AppDbContext _context;

    public DbSeeder(AppDbContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        if (
            await _context.Users.AnyAsync()
            || await _context.Products.AnyAsync()
            || await _context.Expenses.AnyAsync()
            || await _context.Sales.AnyAsync()
            || await _context.Purchases.AnyAsync()
            || await _context.ExpensesByCategory.AnyAsync()
            || await _context.PurchaseSummaries.AnyAsync()
            || await _context.SaleSummaries.AnyAsync()
            || await _context.ExpenseSummaries.AnyAsync()
        )
        {
            return;
        }

        var seedData = JsonConvert.DeserializeObject<SeedData>(File.ReadAllText("seedData.json"));

        if (seedData != null)
        {
            _context.Products.AddRange(seedData.Products);
            _context.Users.AddRange(seedData.Users);
            _context.ExpensesByCategory.AddRange(seedData.ExpensesByCategory);
            _context.Expenses.AddRange(seedData.Expenses);
            _context.Purchases.AddRange(seedData.Purchases);
            _context.Sales.AddRange(seedData.Sales);
            _context.PurchaseSummaries.AddRange(seedData.PurchaseSummaries);
            _context.SaleSummaries.AddRange(seedData.SaleSummaries);
            _context.ExpenseSummaries.AddRange(seedData.ExpenseSummaries);
            await _context.SaveChangesAsync();
        }
    }
}
