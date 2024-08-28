using DevOpsInventoryManagement.DAL.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevOpsInventoryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DashboardController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    [HttpGet("/dashboard")]
    public async Task<IActionResult> GetDashboard()
    {
        var popularProducts = await _context
            .Products.OrderByDescending(p => p.StockQuantity)
            .Take(15)
            .ToListAsync();

        var salesSummary = await _context
            .SaleSummaries.OrderByDescending(e => e.Date)
            .Take(5)
            .ToListAsync();

        var purchaseSummary = await _context
            .PurchaseSummaries.OrderByDescending(e => e.Date)
            .Take(5)
            .ToListAsync();

        var expenseSummary = await _context
            .ExpenseSummaries.OrderByDescending(e => e.Date)
            .Take(5)
            .ToListAsync();

        var expenseByCategorySummaryRaw = await _context
            .ExpensesByCategory.OrderByDescending(e => e.Date)
            .Take(5)
            .ToListAsync();

        var expenseByCategorySummary = expenseByCategorySummaryRaw
            .Select(
                item =>
                    new
                    {
                        item.Id,
                        item.Category,
                        item.Date,
                        Amount = item.Amount.ToString()
                    }
            )
            .ToList();

        return Ok(
            new
            {
                popularProducts,
                salesSummary,
                purchaseSummary,
                expenseSummary,
                expenseByCategorySummary
            }
        );
    }
}
