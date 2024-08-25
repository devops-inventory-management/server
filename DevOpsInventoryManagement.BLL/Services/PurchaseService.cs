using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Services;

public class PurchaseService(IPurchaseRepository purchaseRepository) : IPurchaseService
{
    private readonly IPurchaseRepository _purchaseRepository = purchaseRepository;

    public IQueryable<Purchase> GetAll()
    {
        return _purchaseRepository.GetAll();
    }
}
