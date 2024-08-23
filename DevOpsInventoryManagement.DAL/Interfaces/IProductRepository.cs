using DevOpsInventoryManagement.Domain.Entities;
using System.Collections.Generic;

namespace DevOpsInventoryManagement.DAL.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product, int>
    {
        IEnumerable<Product> GetProductsByName(string name);
        IEnumerable<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice);
        IEnumerable<Product> GetProductsWithLowStock(int threshold);
    }
}