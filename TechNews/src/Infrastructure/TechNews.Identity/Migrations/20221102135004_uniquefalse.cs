using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNews.Identity.Migrations
{
    public partial class uniquefalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c1030ae-b4c7-4123-bb8d-0d7e40d66213");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1e60e98-a2fe-4101-beb3-2a531b3b1800");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3df848c6-d73f-4bdf-b274-0d310c843244", "62bacf2f-57e3-49a0-9e10-5d015bf1aaf3", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f92af5b2-2488-454c-ab53-490545327464", "21614bdb-0fbd-41be-bcdd-206443e7b771", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2c1030ae-b4c7-4123-bb8d-0d7e40d66213", "a8592a46-5c54-4474-8822-295c5071fcbb", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d1e60e98-a2fe-4101-beb3-2a531b3b1800", "359176f4-5ff4-46fc-9b3d-8c730cd720ae", "Viewer", "VIEWER" });
        }
    }
}
