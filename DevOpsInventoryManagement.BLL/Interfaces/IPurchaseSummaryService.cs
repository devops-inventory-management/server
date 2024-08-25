using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces;

public interface IPurchaseSummaryService
{
    IQueryable<PurchaseSummary> GetAll();
}
