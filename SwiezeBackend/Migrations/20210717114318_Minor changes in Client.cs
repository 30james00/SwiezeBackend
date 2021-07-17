using Microsoft.EntityFrameworkCore.Migrations;

namespace SwiezeBackend.Migrations
{
    public partial class MinorchangesinClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Clients",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Clients",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Clients",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Clients",
                newName: "Firstname");
        }
    }
}
