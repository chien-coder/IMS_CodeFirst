using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MemberProjects_API.Migrations
{
    public partial class addtbMP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member_Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", maxLength: 30, nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    isView = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    isUpdate = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    isAdd = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    isDelete = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    IdProject = table.Column<Guid>(type: "uuid", nullable: false),
                    IdUser = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member_Projects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member_Projects");
        }
    }
}
