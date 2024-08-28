using DevOpsInventoryManagement.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsInventoryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SaleController(ISaleService saleService) : ControllerBase
{
    private readonly ISaleService _saleService = saleService;

    [HttpGet("/sale")]
    public IActionResult GetAll()
    {
        return Ok(_saleService.GetAll());
    }
}
