using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.DAL.Repositories;

public class PurchaseRepository(AppDbContext context) : IPurchaseRepository
{
    private readonly AppDbContext _context = context;

    public void Add(Purchase entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Purchase> GetAll()
    {
        return _context.Purchases;
    }

    public Purchase? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
