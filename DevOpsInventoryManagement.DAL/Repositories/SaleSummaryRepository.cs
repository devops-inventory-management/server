using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.DAL.Repositories;

public class SaleSummaryRepository(AppDbContext context) : ISaleSummaryRepository
{
    private readonly AppDbContext _context = context;

    public void Add(SaleSummary entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<SaleSummary> GetAll()
    {
        return _context.SaleSummaries;
    }

    public SaleSummary? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
