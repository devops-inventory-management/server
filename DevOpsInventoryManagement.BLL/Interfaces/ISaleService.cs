using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces;

public interface ISaleService
{
    IQueryable<Sale> GetAll();
}
