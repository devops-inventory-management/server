using DevOpsInventoryManagement.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsInventoryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PurchaseSummaryController(IPurchaseSummaryService purchaseSummaryService)
    : ControllerBase
{
    private readonly IPurchaseSummaryService _purchaseSummaryService = purchaseSummaryService;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_purchaseSummaryService.GetAll());
    }
}
