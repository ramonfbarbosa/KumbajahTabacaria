using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class AddingDataAnnotationColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_ORDERS_OrderId",
                table: "TB_ORDER_ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_PRODUCTS_ProductId",
                table: "TB_ORDER_ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDERS_TB_ADDRESSES_AddressId",
                table: "TB_ORDERS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDERS_TB_ORDER_STATUS_OrderStatusId",
                table: "TB_ORDERS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDERS_TB_USERS_UserId",
                table: "TB_ORDERS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_BRANDS_BrandId",
                table: "TB_PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_CATEGORIES_CategoryId",
                table: "TB_PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_COLORS_ColorId",
                table: "TB_PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_STOCKS_StockId",
                table: "TB_PRODUCTS");

            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "TB_PRODUCTS",
                newName: "STOCK_ID");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "TB_PRODUCTS",
                newName: "COLOR_ID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "TB_PRODUCTS",
                newName: "CATEGORY_ID");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "TB_PRODUCTS",
                newName: "BRAND_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_StockId",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_STOCK_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_ColorId",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_COLOR_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_CategoryId",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_CATEGORY_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_BrandId",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_BRAND_ID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TB_ORDERS",
                newName: "USER_ID");

            migrationBuilder.RenameColumn(
                name: "OrderStatusId",
                table: "TB_ORDERS",
                newName: "ORDER_STATUS_ID");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "TB_ORDERS",
                newName: "ADDRESS_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDERS_UserId",
                table: "TB_ORDERS",
                newName: "IX_TB_ORDERS_USER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDERS_OrderStatusId",
                table: "TB_ORDERS",
                newName: "IX_TB_ORDERS_ORDER_STATUS_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDERS_AddressId",
                table: "TB_ORDERS",
                newName: "IX_TB_ORDERS_ADDRESS_ID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "TB_ORDER_ITEMS",
                newName: "PRODUCT_ID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "TB_ORDER_ITEMS",
                newName: "ORDER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDER_ITEMS_ProductId",
                table: "TB_ORDER_ITEMS",
                newName: "IX_TB_ORDER_ITEMS_PRODUCT_ID");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDER_ITEMS_OrderId",
                table: "TB_ORDER_ITEMS",
                newName: "IX_TB_ORDER_ITEMS_ORDER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_ORDERS_ORDER_ID",
                table: "TB_ORDER_ITEMS",
                column: "ORDER_ID",
                principalTable: "TB_ORDERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_PRODUCTS_PRODUCT_ID",
                table: "TB_ORDER_ITEMS",
                column: "PRODUCT_ID",
                principalTable: "TB_PRODUCTS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDERS_TB_ADDRESSES_ADDRESS_ID",
                table: "TB_ORDERS",
                column: "ADDRESS_ID",
                principalTable: "TB_ADDRESSES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDERS_TB_ORDER_STATUS_ORDER_STATUS_ID",
                table: "TB_ORDERS",
                column: "ORDER_STATUS_ID",
                principalTable: "TB_ORDER_STATUS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDERS_TB_USERS_USER_ID",
                table: "TB_ORDERS",
                column: "USER_ID",
                principalTable: "TB_USERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_BRANDS_BRAND_ID",
                table: "TB_PRODUCTS",
                column: "BRAND_ID",
                principalTable: "TB_BRANDS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_CATEGORIES_CATEGORY_ID",
                table: "TB_PRODUCTS",
                column: "CATEGORY_ID",
                principalTable: "TB_CATEGORIES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_COLORS_COLOR_ID",
                table: "TB_PRODUCTS",
                column: "COLOR_ID",
                principalTable: "TB_COLORS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_STOCKS_STOCK_ID",
                table: "TB_PRODUCTS",
                column: "STOCK_ID",
                principalTable: "TB_STOCKS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_ORDERS_ORDER_ID",
                table: "TB_ORDER_ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_PRODUCTS_PRODUCT_ID",
                table: "TB_ORDER_ITEMS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDERS_TB_ADDRESSES_ADDRESS_ID",
                table: "TB_ORDERS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDERS_TB_ORDER_STATUS_ORDER_STATUS_ID",
                table: "TB_ORDERS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ORDERS_TB_USERS_USER_ID",
                table: "TB_ORDERS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_BRANDS_BRAND_ID",
                table: "TB_PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_CATEGORIES_CATEGORY_ID",
                table: "TB_PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_COLORS_COLOR_ID",
                table: "TB_PRODUCTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PRODUCTS_TB_STOCKS_STOCK_ID",
                table: "TB_PRODUCTS");

            migrationBuilder.RenameColumn(
                name: "STOCK_ID",
                table: "TB_PRODUCTS",
                newName: "StockId");

            migrationBuilder.RenameColumn(
                name: "COLOR_ID",
                table: "TB_PRODUCTS",
                newName: "ColorId");

            migrationBuilder.RenameColumn(
                name: "CATEGORY_ID",
                table: "TB_PRODUCTS",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "BRAND_ID",
                table: "TB_PRODUCTS",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_STOCK_ID",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_StockId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_COLOR_ID",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_CATEGORY_ID",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PRODUCTS_BRAND_ID",
                table: "TB_PRODUCTS",
                newName: "IX_TB_PRODUCTS_BrandId");

            migrationBuilder.RenameColumn(
                name: "USER_ID",
                table: "TB_ORDERS",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ORDER_STATUS_ID",
                table: "TB_ORDERS",
                newName: "OrderStatusId");

            migrationBuilder.RenameColumn(
                name: "ADDRESS_ID",
                table: "TB_ORDERS",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDERS_USER_ID",
                table: "TB_ORDERS",
                newName: "IX_TB_ORDERS_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDERS_ORDER_STATUS_ID",
                table: "TB_ORDERS",
                newName: "IX_TB_ORDERS_OrderStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDERS_ADDRESS_ID",
                table: "TB_ORDERS",
                newName: "IX_TB_ORDERS_AddressId");

            migrationBuilder.RenameColumn(
                name: "PRODUCT_ID",
                table: "TB_ORDER_ITEMS",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ORDER_ID",
                table: "TB_ORDER_ITEMS",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDER_ITEMS_PRODUCT_ID",
                table: "TB_ORDER_ITEMS",
                newName: "IX_TB_ORDER_ITEMS_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_ORDER_ITEMS_ORDER_ID",
                table: "TB_ORDER_ITEMS",
                newName: "IX_TB_ORDER_ITEMS_OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_ORDERS_OrderId",
                table: "TB_ORDER_ITEMS",
                column: "OrderId",
                principalTable: "TB_ORDERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDER_ITEMS_TB_PRODUCTS_ProductId",
                table: "TB_ORDER_ITEMS",
                column: "ProductId",
                principalTable: "TB_PRODUCTS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDERS_TB_ADDRESSES_AddressId",
                table: "TB_ORDERS",
                column: "AddressId",
                principalTable: "TB_ADDRESSES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDERS_TB_ORDER_STATUS_OrderStatusId",
                table: "TB_ORDERS",
                column: "OrderStatusId",
                principalTable: "TB_ORDER_STATUS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ORDERS_TB_USERS_UserId",
                table: "TB_ORDERS",
                column: "UserId",
                principalTable: "TB_USERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_BRANDS_BrandId",
                table: "TB_PRODUCTS",
                column: "BrandId",
                principalTable: "TB_BRANDS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_CATEGORIES_CategoryId",
                table: "TB_PRODUCTS",
                column: "CategoryId",
                principalTable: "TB_CATEGORIES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_COLORS_ColorId",
                table: "TB_PRODUCTS",
                column: "ColorId",
                principalTable: "TB_COLORS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PRODUCTS_TB_STOCKS_StockId",
                table: "TB_PRODUCTS",
                column: "StockId",
                principalTable: "TB_STOCKS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
