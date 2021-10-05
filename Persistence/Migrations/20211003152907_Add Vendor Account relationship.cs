using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddVendorAccountrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Vendors",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_AccountId",
                table: "Vendors",
                column: "AccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendors_AspNetUsers_AccountId",
                table: "Vendors",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendors_AspNetUsers_AccountId",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Vendors_AccountId",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Vendors");
        }
    }
}
