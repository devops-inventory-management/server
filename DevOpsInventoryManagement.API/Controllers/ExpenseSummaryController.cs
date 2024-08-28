using DevOpsInventoryManagement.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsInventoryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExpenseSummaryController(IExpenseSummaryService expenseSummaryService) : ControllerBase
{
    private readonly IExpenseSummaryService _expenseSummaryService = expenseSummaryService;

    [HttpGet("/expense-summary")]
    public IActionResult GetAll()
    {
        return Ok(_expenseSummaryService.GetAll());
    }
}
