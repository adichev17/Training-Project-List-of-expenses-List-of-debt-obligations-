using Microsoft.EntityFrameworkCore.Migrations;

namespace Training_Project__List_of_expenses_and_List_of_debt_obligations_.Migrations
{
    public partial class UPDItemModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ItemsTable",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ItemsTable");
        }
    }
}
