using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticket.DAL.Migrations
{
    public partial class UserTourTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTours");

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
