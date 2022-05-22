using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    PRODUCT_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    LAST_NAME = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    EMAIL = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    PHONE_NUMBER = table.Column<long>(type: "BIGINT", nullable: false),
                    BIRTHDAY = table.Column<DateTime>(type: "date", nullable: false),
                    PASSWORD = table.Column<string>(type: "VARCHAR(180)", maxLength: 180, nullable: false),
                    CPF = table.Column<long>(type: "BIGINT", maxLength: 11, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(180)", maxLength: 180, nullable: false),
                    PRICE = table.Column<decimal>(type: "DECIMAL(10,10)", nullable: false),
                    IMAGE = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    QUANTITY = table.Column<long>(type: "BIGINT", nullable: false),
                    CATEGORY_ID = table.Column<long>(type: "BIGINT", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRODUCT_CATEGORY_CATEGORY_ID",
                        column: x => x.CATEGORY_ID,
                        principalTable: "CATEGORY",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CATEGORY_ID",
                table: "PRODUCT",
                column: "CATEGORY_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "USER");

            migrationBuilder.DropTable(
                name: "CATEGORY");
        }
    }
}
