using DevOpsInventoryManagement.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsInventoryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PurchaseController(IPurchaseService purchaseService) : ControllerBase
{
    private readonly IPurchaseService _purchaseService = purchaseService;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_purchaseService.GetAll());
    }
}
