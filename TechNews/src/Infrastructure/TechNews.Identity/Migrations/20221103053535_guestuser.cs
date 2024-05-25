using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNews.Identity.Migrations
{
    public partial class guestuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3df848c6-d73f-4bdf-b274-0d310c843244");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f92af5b2-2488-454c-ab53-490545327464");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "979eea32-61de-4f67-978e-9e90736e2907", "d469df76-5e08-468f-9539-a4320d07ca2f", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbe59c53-acf8-412d-80bb-ed531bf8b03c", "5b9e4dfa-a0b2-4181-8322-5d43bb7fae4c", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "979eea32-61de-4f67-978e-9e90736e2907");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbe59c53-acf8-412d-80bb-ed531bf8b03c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3df848c6-d73f-4bdf-b274-0d310c843244", "62bacf2f-57e3-49a0-9e10-5d015bf1aaf3", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f92af5b2-2488-454c-ab53-490545327464", "21614bdb-0fbd-41be-bcdd-206443e7b771", "Administrator", "ADMINISTRATOR" });
        }
    }
}
