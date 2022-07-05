using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class TestandoUmaCoisaFIX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_CLIENTES_UserId",
                table: "TAB_PEDIDOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_ENDERECOS_AddressId",
                table: "TAB_PEDIDOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_STATUS_DO_PEDIDO_OrderStatusId",
                table: "TAB_PEDIDOS");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TAB_PEDIDOS",
                newName: "USER_ID");

            migrationBuilder.RenameColumn(
                name: "OrderStatusId",
                table: "TAB_PEDIDOS",
                newName: "ORDER_STATUS_ID");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "TAB_PEDIDOS",
                newName: "ADDRESS_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PEDIDOS_UserId",
                table: "TAB_PEDIDOS",
                newName: "IX_TAB_PEDIDOS_USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PEDIDOS_OrderStatusId",
                table: "TAB_PEDIDOS",
                newName: "IX_TAB_PEDIDOS_ORDER_STATUS_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PEDIDOS_AddressId",
                table: "TAB_PEDIDOS",
                newName: "IX_TAB_PEDIDOS_ADDRESS_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_CLIENTES_USER_ID",
                table: "TAB_PEDIDOS",
                column: "USER_ID",
                principalTable: "TAB_CLIENTES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_ENDERECOS_ADDRESS_ID",
                table: "TAB_PEDIDOS",
                column: "ADDRESS_ID",
                principalTable: "TAB_ENDERECOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_STATUS_DO_PEDIDO_ORDER_STATUS_ID",
                table: "TAB_PEDIDOS",
                column: "ORDER_STATUS_ID",
                principalTable: "TAB_STATUS_DO_PEDIDO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_CLIENTES_USER_ID",
                table: "TAB_PEDIDOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_ENDERECOS_ADDRESS_ID",
                table: "TAB_PEDIDOS");

            migrationBuilder.DropForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_STATUS_DO_PEDIDO_ORDER_STATUS_ID",
                table: "TAB_PEDIDOS");

            migrationBuilder.RenameColumn(
                name: "USER_ID",
                table: "TAB_PEDIDOS",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ORDER_STATUS_ID",
                table: "TAB_PEDIDOS",
                newName: "OrderStatusId");

            migrationBuilder.RenameColumn(
                name: "ADDRESS_ID",
                table: "TAB_PEDIDOS",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PEDIDOS_USER_ID",
                table: "TAB_PEDIDOS",
                newName: "IX_TAB_PEDIDOS_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PEDIDOS_ORDER_STATUS_ID",
                table: "TAB_PEDIDOS",
                newName: "IX_TAB_PEDIDOS_OrderStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_TAB_PEDIDOS_ADDRESS_ID",
                table: "TAB_PEDIDOS",
                newName: "IX_TAB_PEDIDOS_AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_CLIENTES_UserId",
                table: "TAB_PEDIDOS",
                column: "UserId",
                principalTable: "TAB_CLIENTES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_ENDERECOS_AddressId",
                table: "TAB_PEDIDOS",
                column: "AddressId",
                principalTable: "TAB_ENDERECOS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TAB_PEDIDOS_TAB_STATUS_DO_PEDIDO_OrderStatusId",
                table: "TAB_PEDIDOS",
                column: "OrderStatusId",
                principalTable: "TAB_STATUS_DO_PEDIDO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
