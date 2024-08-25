using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.DAL.Repositories;

public class ExpenseByCategoryRepository(AppDbContext context) : IExpenseByCategoryRepository
{
    private readonly AppDbContext _context = context;

    public void Add(ExpenseByCategory entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<ExpenseByCategory> GetAll()
    {
        return _context.ExpensesByCategory;
    }

    public ExpenseByCategory? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
