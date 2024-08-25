using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsInventoryManagement.Domain.Entities;

public class ExpenseByCategory
{
    public int Id { get; set; }
    public int ExpenseSummaryId { get; set; }
    public DateTime Date { get; set; }
    public string Category { get; set; } = null!;

    [Column(TypeName = "bigint")]
    public int Amount { get; set; }
}
