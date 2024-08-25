using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Services;

public class ExpenseService(IExpenseRepository expenseRepository) : IExpenseService
{
    private readonly IExpenseRepository _expenseRepository = expenseRepository;

    public IQueryable<Expense> GetAll()
    {
        return _expenseRepository.GetAll();
    }
}
