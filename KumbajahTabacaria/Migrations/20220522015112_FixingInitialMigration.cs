using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class FixingInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_USER",
                table: "USER");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "CATEGORY");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "CATEGORY");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "USER");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "USER");

            migrationBuilder.RenameTable(
                name: "USER",
                newName: "ACCOUNT");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PRODUCT",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CATEGORY",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ACCOUNT",
                newName: "ID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PRODUCT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BIRTHDAY",
                table: "ACCOUNT",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ACCOUNT",
                table: "ACCOUNT",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ACCOUNT",
                table: "ACCOUNT");

            migrationBuilder.RenameTable(
                name: "ACCOUNT",
                newName: "USER");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PRODUCT",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CATEGORY",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "USER",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "PRODUCT",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "CATEGORY",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "CATEGORY",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BIRTHDAY",
                table: "USER",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "USER",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "USER",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_USER",
                table: "USER",
                column: "Id");
        }
    }
}
