using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticket.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "UserKeys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    ActivationKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTours", x => x.Id);
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
                    { 57, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "18:00", "Ankara", 2 },
                    { 56, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "17:00", "Ankara", 1 },
                    { 55, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "16:00", "Ankara", 42 },
                    { 54, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "15:00", "Ankara", 44 },
                    { 53, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 43 },
                    { 52, new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 51, new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 50, new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 49, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 48, new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 47, new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 46, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 45, new DateTime(2020, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 44, new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 43, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 42, new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 58, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 59, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "15:00", "Ankara", 20 },
                    { 60, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 61, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 77, new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 76, new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 75, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 74, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 73, new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 72, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 71, new DateTime(2020, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 41, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 70, new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 68, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 67, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 66, new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 65, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 64, new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 63, new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 62, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 69, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 40, new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 38, new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 78, new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 },
                    { 16, new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 15, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 14, new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 13, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 12, new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 11, new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 10, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 17, new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 9, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 7, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "17:00", "Ankara", 20 },
                    { 6, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 5, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "20:00", "Ankara", 2 },
                    { 4, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "19:00", "Ankara", 1 },
                    { 3, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "18:00", "Ankara", 42 },
                    { 2, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "17:00", "Ankara", 44 },
                    { 1, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 43 },
                    { 8, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 18, new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 19, new DateTime(2020, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 20, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 37, new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 36, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 35, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 34, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 33, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "11:00", "İzmir", 20 },
                    { 32, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 31, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "20:00", "İzmir", 2 },
                    { 30, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "19:00", "İzmir", 1 },
                    { 29, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "12:00", "İzmir", 42 },
                    { 28, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "11:00", "İzmir", 44 },
                    { 27, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 43 },
                    { 26, new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 25, new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 24, new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 23, new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 22, new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 21, new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 50, "16:00", "Ankara", 20 },
                    { 39, new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "İstanbul", 30, "10:00", "İzmir", 20 },
                    { 79, new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "İzmir", 20, "14:00", "Ankara", 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "UserKeys");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTours");
        }
    }
}
