using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticket.DAL.Migrations
{
    public partial class CityIdChangedAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Cities",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cities",
                newName: "CityId");
        }
    }
}
