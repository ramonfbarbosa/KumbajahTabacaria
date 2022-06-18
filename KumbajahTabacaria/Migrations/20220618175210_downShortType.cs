using Microsoft.EntityFrameworkCore.Migrations;

namespace KumbajahTabacaria.Migrations
{
    public partial class downShortType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BIRTHDATE",
                table: "TB_USERS",
                newName: "BIRTH_DATE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BIRTH_DATE",
                table: "TB_USERS",
                newName: "BIRTHDATE");
        }
    }
}
