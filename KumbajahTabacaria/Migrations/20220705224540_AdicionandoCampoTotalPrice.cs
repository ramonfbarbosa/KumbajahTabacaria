using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class AdicionandoCampoTotalPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PRECO",
                table: "TAB_PEDIDOS",
                type: "DECIMAL(10,10)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PRECO",
                table: "TAB_PEDIDOS");
        }
    }
}
