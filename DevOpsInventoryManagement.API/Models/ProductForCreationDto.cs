namespace DevOpsInventoryManagement.API.Models;

public class ProductForCreationDto
{
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal? Rating { get; set; }
    public int StockQuantity { get; set; }
    public string? Description { get; set; }
}
