using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticket.DAL.Migrations
{
    public partial class CityAndToursAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    RowNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    From = table.Column<string>(nullable: true),
                    To = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    UserCount = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "RowNumber" },
                values: new object[,]
                {
                    { 1, "İstanbul", 1 },
                    { 2, "Ankara", 2 },
                    { 3, "İzmir", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Date", "From", "Price", "Time", "To", "UserCount" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 1, 21, 16, 12, 32, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 30 },
                    { 2, new DateTime(2020, 1, 1, 21, 16, 12, 33, DateTimeKind.Local), "İstanbul", 50, "17:00", "Ankara", 44 },
                    { 3, new DateTime(2020, 1, 1, 21, 16, 12, 33, DateTimeKind.Local), "İstanbul", 50, "18:00", "Ankara", 20 },
                    { 4, new DateTime(2020, 1, 2, 21, 16, 12, 33, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 5, new DateTime(2020, 1, 2, 21, 16, 12, 33, DateTimeKind.Local), "İstanbul", 50, "18:00", "Ankara", 20 },
                    { 6, new DateTime(2020, 1, 1, 21, 16, 12, 33, DateTimeKind.Local), "İstanbul", 30, "16:00", "İzmir", 30 },
                    { 7, new DateTime(2020, 1, 1, 21, 16, 12, 33, DateTimeKind.Local), "İstanbul", 30, "17:00", "İzmir", 44 },
                    { 8, new DateTime(2020, 1, 1, 21, 16, 12, 33, DateTimeKind.Local), "İstanbul", 30, "18:00", "İzmir", 1 },
                    { 9, new DateTime(2020, 1, 1, 21, 16, 12, 33, DateTimeKind.Local), "İzmir", 20, "16:00", "Ankara", 30 },
                    { 10, new DateTime(2020, 1, 1, 21, 16, 12, 33, DateTimeKind.Local), "İzmir", 20, "16:00", "Ankara", 44 },
                    { 11, new DateTime(2020, 1, 1, 21, 16, 12, 33, DateTimeKind.Local), "İzmir", 20, "16:00", "Ankara", 1 },
                    { 12, new DateTime(2020, 1, 1, 21, 16, 12, 33, DateTimeKind.Local), "İzmir", 20, "16:00", "Ankara", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
