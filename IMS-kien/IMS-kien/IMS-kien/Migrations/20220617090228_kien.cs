using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS_kien.Migrations
{
    public partial class kien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    idProject = table.Column<string>(type: "text", nullable: false),
                    projectCode = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    projectName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    dateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false),
                    creator = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    idLeader = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.idProject);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    idUser = table.Column<string>(type: "text", nullable: false),
                    nameUser = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    phoneNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    gender = table.Column<byte>(type: "smallint", nullable: false),
                    DoB = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    addR = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    dateCreate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dateEdit = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    creator = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    editor = table.Column<string>(type: "text", nullable: false),
                    account = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    pwd = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    isActive = table.Column<byte>(type: "smallint", nullable: false),
                    idRole = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.idUser);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
