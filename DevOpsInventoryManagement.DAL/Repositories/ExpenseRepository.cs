using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.DAL.Repositories;

public class ExpenseRepository(AppDbContext context) : IExpenseRepository
{
    private readonly AppDbContext _context = context;

    public void Add(Expense entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Expense> GetAll()
    {
        return _context.Expenses;
    }

    public Expense? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
