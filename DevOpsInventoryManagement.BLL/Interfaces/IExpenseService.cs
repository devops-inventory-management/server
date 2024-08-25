using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces;

public interface IExpenseService
{
    IQueryable<Expense> GetAll();
}
