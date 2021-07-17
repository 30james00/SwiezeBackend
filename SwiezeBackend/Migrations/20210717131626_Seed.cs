using Microsoft.EntityFrameworkCore.Migrations;

namespace SwiezeBackend.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UnitTypes",
                type: "character varying(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "UnitTypes",
                columns: new[] { "UnitTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "redundant" },
                    { 2, "Ergonomic" },
                    { 3, "Buckinghamshire" },
                    { 4, "bandwidth" },
                    { 5, "withdrawal" },
                    { 6, "1080p" },
                    { 7, "TCP" },
                    { 8, "Re-engineered" },
                    { 9, "interface" },
                    { 10, "artificial intelligence" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "UnitTypeId",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UnitTypes",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(60)",
                oldMaxLength: 60);
        }
    }
}
