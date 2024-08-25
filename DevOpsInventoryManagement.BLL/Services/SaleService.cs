using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Services;

public class SaleService(ISaleRepository saleRepository) : ISaleService
{
    private readonly ISaleRepository _saleRepository = saleRepository;

    public IQueryable<Sale> GetAll()
    {
        return _saleRepository.GetAll();
    }
}
