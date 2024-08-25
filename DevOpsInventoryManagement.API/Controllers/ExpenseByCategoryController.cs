using DevOpsInventoryManagement.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsInventoryManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExpenseByCategoryController(IExpenseByCategoryService expenseByCategoryService)
    : ControllerBase
{
    private readonly IExpenseByCategoryService _expenseByCategoryService = expenseByCategoryService;

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_expenseByCategoryService.GetAll());
    }
}
