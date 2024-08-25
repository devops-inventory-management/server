using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Services;

public class PurchaseSummaryService(IPurchaseSummaryRepository purchaseSummaryRepository)
    : IPurchaseSummaryService
{
    private readonly IPurchaseSummaryRepository _purchaseSummaryRepository =
        purchaseSummaryRepository;

    public IQueryable<PurchaseSummary> GetAll()
    {
        return _purchaseSummaryRepository.GetAll();
    }
}
