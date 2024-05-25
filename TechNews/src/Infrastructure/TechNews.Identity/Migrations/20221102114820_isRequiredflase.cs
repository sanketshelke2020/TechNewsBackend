using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNews.Identity.Migrations
{
    public partial class isRequiredflase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a94aff2-a58a-48c7-b6ce-63750dfce5b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ae8e68f-81fc-4987-8885-6c35aacda97b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "374919f2-48a6-4e7d-b5c2-c9b9cdb1a652", "7b3249e3-f242-497c-beea-59f6615e9a0e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "379cf5ef-502d-4078-b9d4-3a33ad2ab23b", "3d1875d7-9663-4ef1-8b9f-7f2f0b95c741", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "374919f2-48a6-4e7d-b5c2-c9b9cdb1a652");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "379cf5ef-502d-4078-b9d4-3a33ad2ab23b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a94aff2-a58a-48c7-b6ce-63750dfce5b0", "0211f0ae-5753-4c75-9faf-cf99906544a5", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ae8e68f-81fc-4987-8885-6c35aacda97b", "fe8a8f9a-6c3e-49a4-b24e-f4f93fa987f0", "Viewer", "VIEWER" });
        }
    }
}
