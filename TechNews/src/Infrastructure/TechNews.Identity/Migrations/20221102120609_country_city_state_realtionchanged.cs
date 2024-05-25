using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNews.Identity.Migrations
{
    public partial class country_city_state_realtionchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "28dc3923-39ca-4f1a-a630-667aa9183e04", "1b066a9f-84be-4377-a235-af271a865fc6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36202aa5-d079-429a-9d90-15c9bd87f7ac", "a9a963d4-66e0-4a09-b3fb-d97628d0d7ed", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28dc3923-39ca-4f1a-a630-667aa9183e04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36202aa5-d079-429a-9d90-15c9bd87f7ac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "374919f2-48a6-4e7d-b5c2-c9b9cdb1a652", "7b3249e3-f242-497c-beea-59f6615e9a0e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "379cf5ef-502d-4078-b9d4-3a33ad2ab23b", "3d1875d7-9663-4ef1-8b9f-7f2f0b95c741", "Viewer", "VIEWER" });
        }
    }
}
