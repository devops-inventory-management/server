using DevOpsInventoryManagement.DAL.Contexts;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.DAL.Repositories;

public class SaleRepository(AppDbContext context) : ISaleRepository
{
    private readonly AppDbContext _context = context;

    public void Add(Sale entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Sale> GetAll()
    {
        return _context.Sales;
    }

    public Sale? GetById(int id)
    {
        throw new NotImplementedException();
    }
}
