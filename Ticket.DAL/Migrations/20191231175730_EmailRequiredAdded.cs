using Microsoft.EntityFrameworkCore.Migrations;

namespace Ticket.DAL.Migrations
{
    public partial class EmailRequiredAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Code", "Email", "IsActive", "Name", "Password", "Surname" },
                values: new object[] { 1, null, "test1@gmail.com", true, "test1", "test", "testSoyad" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Code", "Email", "IsActive", "Name", "Password", "Surname" },
                values: new object[] { 2, null, "test2@gmail.com", true, "test2", "test", "testSoyad" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Code", "Email", "IsActive", "Name", "Password", "Surname" },
                values: new object[] { 3, null, "test3@gmail.com", true, "test3", "test", "testSoyad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
