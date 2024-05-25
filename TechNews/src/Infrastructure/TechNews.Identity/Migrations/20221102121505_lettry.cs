using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNews.Identity.Migrations
{
    public partial class lettry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "09b22e50-7ae4-4818-b7b9-6fbee1b0a24b", "7b7570ba-99e9-4c3c-928f-8d91989ddb36", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a0457c5-2336-44a2-ab28-821b89c950cd", "80b57d0f-617c-4809-b1dd-d183f29474ff", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09b22e50-7ae4-4818-b7b9-6fbee1b0a24b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a0457c5-2336-44a2-ab28-821b89c950cd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28dc3923-39ca-4f1a-a630-667aa9183e04", "1b066a9f-84be-4377-a235-af271a865fc6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36202aa5-d079-429a-9d90-15c9bd87f7ac", "a9a963d4-66e0-4a09-b3fb-d97628d0d7ed", "Viewer", "VIEWER" });
        }
    }
}
