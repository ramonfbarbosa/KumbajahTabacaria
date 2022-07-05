using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class AdicionandoCampoTotalPriceFIX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PRECO",
                table: "TAB_PEDIDOS",
                newName: "PRECO_TOTAL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PRECO_TOTAL",
                table: "TAB_PEDIDOS",
                newName: "PRECO");
        }
    }
}
