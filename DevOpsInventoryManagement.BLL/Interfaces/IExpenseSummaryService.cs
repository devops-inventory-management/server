using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces;

public interface IExpenseSummaryService
{
    IQueryable<ExpenseSummary> GetAll();
}
