using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class SettingVarChar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "STREET",
                table: "TB_ADDRESSES",
                type: "VARCHAR(MAX)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "STATE",
                table: "TB_ADDRESSES",
                type: "VARCHAR(MAX)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "REFERENCE",
                table: "TB_ADDRESSES",
                type: "VARCHAR(MAX)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "COMPLEMENT",
                table: "TB_ADDRESSES",
                type: "VARCHAR(MAX)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CITY",
                table: "TB_ADDRESSES",
                type: "VARCHAR(MAX)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "STREET",
                table: "TB_ADDRESSES",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "STATE",
                table: "TB_ADDRESSES",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "REFERENCE",
                table: "TB_ADDRESSES",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "COMPLEMENT",
                table: "TB_ADDRESSES",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CITY",
                table: "TB_ADDRESSES",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)",
                oldMaxLength: 20);
        }
    }
}
