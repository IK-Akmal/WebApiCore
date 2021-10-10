using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCore.Api.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirtDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temp = table.Column<float>(type: "real", nullable: false),
                    MinTemp = table.Column<float>(type: "real", nullable: false),
                    MaxTemp = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirtDate", "Email", "Name" },
                values: new object[] { new Guid("0eab7e53-1954-42af-b525-8f39e1513958"), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nick" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BirtDate", "Email", "Name" },
                values: new object[] { new Guid("f5fc0cde-d2bd-4243-aafc-d2fe138a2094"), new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nick" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Weathers");
        }
    }
}
