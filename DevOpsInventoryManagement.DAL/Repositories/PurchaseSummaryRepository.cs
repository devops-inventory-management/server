using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.DAL.Repositories;

public class PurchaseSummaryRepository(AppDbContext context) : IPurchaseSummaryRepository
{
    private readonly AppDbContext _context = context;

    public void Add(PurchaseSummary entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<PurchaseSummary> GetAll()
    {
        return _context.PurchaseSummaries;
    }

    public PurchaseSummary? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
