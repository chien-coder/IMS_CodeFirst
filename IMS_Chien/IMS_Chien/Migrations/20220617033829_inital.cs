using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS_Chien.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    idRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nameRole = table.Column<string>(type: "varchar(50)", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    isActive = table.Column<byte>(type: "bit", nullable: false),
                    creator = table.Column<string>(type: "uniqueidentifier", nullable: false),
                    editor = table.Column<string>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.idRole);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
