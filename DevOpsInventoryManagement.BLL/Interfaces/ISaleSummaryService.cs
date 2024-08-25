using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces;

public interface ISaleSummaryService
{
    IQueryable<SaleSummary> GetAll();
}
