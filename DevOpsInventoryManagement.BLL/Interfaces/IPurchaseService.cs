using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces;

public interface IPurchaseService
{
    IQueryable<Purchase> GetAll();
}
