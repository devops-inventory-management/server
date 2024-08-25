using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.DAL.Repositories;

public class ExpenseSummaryRepository(AppDbContext context) : IExpenseSummaryRepository
{
    private readonly AppDbContext _context = context;

    public void Add(ExpenseSummary entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<ExpenseSummary> GetAll()
    {
        return _context.ExpenseSummaries;
    }

    public ExpenseSummary? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
