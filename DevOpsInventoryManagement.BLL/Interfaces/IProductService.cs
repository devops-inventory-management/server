using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Interfaces;

public interface IProductService
{
    IQueryable<Product> GetAll();
    Product? GetById(int id);
    void Add(Product product);
}
