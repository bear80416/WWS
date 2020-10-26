using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myspace.Migrations
{
    public partial class MainDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Pic = table.Column<string>(nullable: true),
                    Writer = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Resgiter",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    City = table.Column<int>(nullable: false),
                    Commutermode = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Terms = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resgiter", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "ID", "Department", "Email", "Mobile", "Name", "Title" },
                values: new object[] { 1, "管理室", "Admin@com", "0912345678", "管理員", "管理員" });

            migrationBuilder.InsertData(
                table: "Resgiter",
                columns: new[] { "ID", "City", "Comment", "Commutermode", "Email", "Gender", "Name", "Nickname", "Password", "Terms" },
                values: new object[] { 1, 4, "Nothing", "1", "Admin@com", 1, "Henry Wu", "0912345678", "q8004166", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Resgiter");
        }
    }
}
