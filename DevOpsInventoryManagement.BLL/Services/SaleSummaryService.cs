using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Services;

public class SaleSummaryService(ISaleSummaryRepository saleSummaryRepository) : ISaleSummaryService
{
    private readonly ISaleSummaryRepository _saleSummaryRepository = saleSummaryRepository;

    public IQueryable<SaleSummary> GetAll()
    {
        return _saleSummaryRepository.GetAll();
    }
}
