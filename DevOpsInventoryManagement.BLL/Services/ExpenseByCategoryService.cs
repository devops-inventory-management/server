using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Services;

public class ExpenseByCategoryService(IExpenseByCategoryRepository expenseByCategoryRepository)
    : IExpenseByCategoryService
{
    private readonly IExpenseByCategoryRepository _expenseByCategoryRepository =
        expenseByCategoryRepository;

    public IQueryable<ExpenseByCategory> GetAll()
    {
        return _expenseByCategoryRepository.GetAll();
    }
}
