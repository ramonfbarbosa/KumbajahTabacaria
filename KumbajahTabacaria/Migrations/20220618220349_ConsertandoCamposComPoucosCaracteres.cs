using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class ConsertandoCamposComPoucosCaracteres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PHONE_NUMBER",
                table: "TB_USERS",
                type: "VARCHAR(80)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "STATUS",
                table: "TB_ORDER_STATUS",
                type: "VARCHAR(80)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(10)");

            migrationBuilder.AlterColumn<string>(
                name: "COLOR_NAME",
                table: "TB_COLORS",
                type: "VARCHAR(80)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(15)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PHONE_NUMBER",
                table: "TB_USERS",
                type: "VARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "STATUS",
                table: "TB_ORDER_STATUS",
                type: "VARCHAR(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)");

            migrationBuilder.AlterColumn<string>(
                name: "COLOR_NAME",
                table: "TB_COLORS",
                type: "VARCHAR(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)");
        }
    }
}
