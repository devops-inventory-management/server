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
        if (await _context.Products.AnyAsync())
        {
            return;
        }

        // pwd
        var currentDirectory = Directory.GetCurrentDirectory();

        var products = JsonConvert.DeserializeObject<List<Product>>(
            File.ReadAllText(Path.Combine(currentDirectory!, "products.json"))
        );

        if (products != null)
        {
            _context.Products.AddRange(products);
            await _context.SaveChangesAsync();
        }
    }
}
