using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Services;

public class ExpenseSummaryService(IExpenseSummaryRepository expenseSummaryRepository)
    : IExpenseSummaryService
{
    private readonly IExpenseSummaryRepository _expenseSummaryRepository = expenseSummaryRepository;

    public IQueryable<ExpenseSummary> GetAll()
    {
        return _expenseSummaryRepository.GetAll();
    }
}
