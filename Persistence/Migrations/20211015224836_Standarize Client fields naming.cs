using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class StandarizeClientfieldsnaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Clients",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clients",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Clients",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Clients",
                newName: "Name");
        }
    }
}
