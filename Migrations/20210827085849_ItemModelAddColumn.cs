using Microsoft.EntityFrameworkCore.Migrations;

namespace Training_Project__List_of_expenses_and_List_of_debt_obligations_.Migrations
{
    public partial class ItemModelAddColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "ItemsTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lender",
                table: "ItemsTable",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "ItemsTable");

            migrationBuilder.DropColumn(
                name: "Lender",
                table: "ItemsTable");
        }
    }
}
