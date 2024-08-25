using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces;

public interface IExpenseByCategoryService
{
    IQueryable<ExpenseByCategory> GetAll();
}
