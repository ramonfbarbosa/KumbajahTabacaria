using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class MigracaoTeste4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ADDRESSES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    STREET = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    STATE = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    CITY = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    DISTRICT = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    NUMBER = table.Column<int>(type: "INT", nullable: false),
                    COMPLEMENT = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: true),
                    REFERENCE = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ADDRESSES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_BRANDS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_BRANDS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_CATEGORIES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CATEGORIES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_COLORS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COLOR_NAME = table.Column<string>(type: "VARCHAR(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_COLORS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_ORDER_STATUS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STATUS = table.Column<string>(type: "VARCHAR(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ORDER_STATUS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_STOCKS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QUANTITY = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_STOCKS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_USERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    LAST_NAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    EMAIL = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    BIRTHDATE = table.Column<DateTime>(type: "DATE", nullable: false),
                    PASSWORD = table.Column<string>(type: "VARCHAR(180)", maxLength: 180, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: true),
                    PHONE_NUMBER = table.Column<string>(type: "VARCHAR(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USERS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUCTS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(180)", maxLength: 180, nullable: false),
                    PRICE = table.Column<decimal>(type: "DECIMAL(10,10)", nullable: false),
                    IMAGE = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "INT", nullable: false),
                    BrandId = table.Column<int>(type: "INT", nullable: false),
                    StockId = table.Column<int>(type: "INT", nullable: false),
                    ColorId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUCTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_PRODUCTS_TB_BRANDS_BrandId",
                        column: x => x.BrandId,
                        principalTable: "TB_BRANDS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PRODUCTS_TB_CATEGORIES_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "TB_CATEGORIES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PRODUCTS_TB_COLORS_ColorId",
                        column: x => x.ColorId,
                        principalTable: "TB_COLORS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PRODUCTS_TB_STOCKS_StockId",
                        column: x => x.StockId,
                        principalTable: "TB_STOCKS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressUser",
                columns: table => new
                {
                    AddressesId = table.Column<int>(type: "INT", nullable: false),
                    UsersId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressUser", x => new { x.AddressesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AddressUser_TB_ADDRESSES_AddressesId",
                        column: x => x.AddressesId,
                        principalTable: "TB_ADDRESSES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressUser_TB_USERS_UsersId",
                        column: x => x.UsersId,
                        principalTable: "TB_USERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ORDERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BUY_MOMENT = table.Column<DateTime>(type: "DATE", maxLength: 20, nullable: false),
                    PHONE_NUMBER = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    OrderStatusId = table.Column<int>(type: "INT", nullable: false),
                    UserId = table.Column<int>(type: "INT", nullable: false),
                    AddressId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ORDERS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_ORDERS_TB_ADDRESSES_AddressId",
                        column: x => x.AddressId,
                        principalTable: "TB_ADDRESSES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_ORDERS_TB_ORDER_STATUS_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "TB_ORDER_STATUS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_ORDERS_TB_USERS_UserId",
                        column: x => x.UserId,
                        principalTable: "TB_USERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ORDER_ITEMS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QUANTITY = table.Column<int>(type: "INT", nullable: false),
                    PRICE = table.Column<decimal>(type: "DECIMAL(10,10)", maxLength: 20, nullable: false),
                    OrderId = table.Column<int>(type: "INT", nullable: false),
                    ProductId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ORDER_ITEMS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_ORDER_ITEMS_TB_ORDERS_OrderId",
                        column: x => x.OrderId,
                        principalTable: "TB_ORDERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_ORDER_ITEMS_TB_PRODUCTS_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TB_PRODUCTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressUser_UsersId",
                table: "AddressUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ORDER_ITEMS_OrderId",
                table: "TB_ORDER_ITEMS",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ORDER_ITEMS_ProductId",
                table: "TB_ORDER_ITEMS",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ORDERS_AddressId",
                table: "TB_ORDERS",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ORDERS_OrderStatusId",
                table: "TB_ORDERS",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ORDERS_UserId",
                table: "TB_ORDERS",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUCTS_BrandId",
                table: "TB_PRODUCTS",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUCTS_CategoryId",
                table: "TB_PRODUCTS",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUCTS_ColorId",
                table: "TB_PRODUCTS",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUCTS_StockId",
                table: "TB_PRODUCTS",
                column: "StockId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressUser");

            migrationBuilder.DropTable(
                name: "TB_ORDER_ITEMS");

            migrationBuilder.DropTable(
                name: "TB_ORDERS");

            migrationBuilder.DropTable(
                name: "TB_PRODUCTS");

            migrationBuilder.DropTable(
                name: "TB_ADDRESSES");

            migrationBuilder.DropTable(
                name: "TB_ORDER_STATUS");

            migrationBuilder.DropTable(
                name: "TB_USERS");

            migrationBuilder.DropTable(
                name: "TB_BRANDS");

            migrationBuilder.DropTable(
                name: "TB_CATEGORIES");

            migrationBuilder.DropTable(
                name: "TB_COLORS");

            migrationBuilder.DropTable(
                name: "TB_STOCKS");
        }
    }
}
