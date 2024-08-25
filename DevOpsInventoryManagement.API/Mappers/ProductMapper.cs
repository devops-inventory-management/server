using DevOpsInventoryManagement.API.Models;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.API.Mappers;

public static class ProductMapper
{
    public static Product ToDomain(this ProductForCreationDto product)
    {
        return new Product
        {
            Name = product.Name,
            Price = product.Price,
            Rating = product.Rating,
            StockQuantity = product.StockQuantity,
            Description = product.Description
        };
    }
}
