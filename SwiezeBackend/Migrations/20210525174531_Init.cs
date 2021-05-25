﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SwiezeBackend.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Mail = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Phone = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Voivodeship = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    PostalCode = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    City = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    Street = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    HouseNumber = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    FlatNumber = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
