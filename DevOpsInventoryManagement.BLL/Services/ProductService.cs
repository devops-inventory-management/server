using DevOpsInventoryManagement.BLL.Interfaces;
using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.BLL.Services;

public class ProductService(IProductRepository productRepository) : IProductService
{
    private readonly IProductRepository _productRepository = productRepository;

    public void Add(Product product)
    {
        _productRepository.Add(product);
    }

    public IQueryable<Product> GetAll()
    {
        return _productRepository.GetAll();
    }

    public Product? GetById(int id)
    {
        return _productRepository.GetById(id);
    }
}
