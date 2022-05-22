using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class FixingCreatedAndUpdatedTimeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "PRODUCT",
                newName: "UPDATED_TIME");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "PRODUCT",
                newName: "CREATED_TIME");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UPDATED_TIME",
                table: "PRODUCT",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CREATED_TIME",
                table: "PRODUCT",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UPDATED_TIME",
                table: "PRODUCT",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "CREATED_TIME",
                table: "PRODUCT",
                newName: "CreatedTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateTime",
                table: "PRODUCT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PRODUCT",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");
        }
    }
}
