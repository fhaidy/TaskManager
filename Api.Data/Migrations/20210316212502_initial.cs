using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolTask",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Students = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolTask", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolTask");
        }
    }
}
