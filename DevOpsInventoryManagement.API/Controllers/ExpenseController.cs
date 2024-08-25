using DevOpsInventoryManagement.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsInventoryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExpenseController(IExpenseService expenseService) : ControllerBase
{
    private readonly IExpenseService _expenseService = expenseService;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_expenseService.GetAll());
    }
}
