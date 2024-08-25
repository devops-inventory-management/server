using System.ComponentModel.DataAnnotations.Schema;

namespace DevOpsInventoryManagement.Domain.Entities;

public class Expense
{
    public int Id { get; set; }
    public string Category { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}
