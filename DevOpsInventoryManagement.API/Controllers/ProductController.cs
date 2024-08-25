using DevOpsInventoryManagement.API.Mappers;
using DevOpsInventoryManagement.API.Models;
using DevOpsInventoryManagement.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsInventoryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController(IProductService productService) : ControllerBase
{
    private readonly IProductService _productService = productService;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_productService.GetAll());
    }

    [HttpPost]
    public IActionResult Add(ProductForCreationDto product)
    {
        _productService.Add(product.ToDomain());
        return Ok();
    }
}
