using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevOpsInventoryManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class ExpenseByCategory_CategoryTypeToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "ExpensesByCategory",
                type: "text",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Category",
                table: "ExpensesByCategory",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
