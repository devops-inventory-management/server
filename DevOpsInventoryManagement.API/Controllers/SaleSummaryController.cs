using DevOpsInventoryManagement.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsInventoryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SaleSummaryController(ISaleSummaryService saleSummaryService) : ControllerBase
{
    private readonly ISaleSummaryService _saleSummaryService = saleSummaryService;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_saleSummaryService.GetAll());
    }
}
