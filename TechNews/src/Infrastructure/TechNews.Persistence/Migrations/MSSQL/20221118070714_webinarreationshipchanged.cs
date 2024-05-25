using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNews.Persistence.Migrations.MSSQL
{
    public partial class webinarreationshipchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebinarWebinarHolder");

            migrationBuilder.DropColumn(
                name: "WebinarHolderId",
                table: "Webinars");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2023, 9, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2023, 8, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2023, 3, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2023, 7, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2023, 3, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2023, 5, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 18, 7, 7, 12, 759, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.CreateIndex(
                name: "IX_WebinarHolders_WebinarId",
                table: "WebinarHolders",
                column: "WebinarId");

            migrationBuilder.AddForeignKey(
                name: "FK_WebinarHolders_Webinars_WebinarId",
                table: "WebinarHolders",
                column: "WebinarId",
                principalTable: "Webinars",
                principalColumn: "WebinarId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebinarHolders_Webinars_WebinarId",
                table: "WebinarHolders");

            migrationBuilder.DropIndex(
                name: "IX_WebinarHolders_WebinarId",
                table: "WebinarHolders");

            migrationBuilder.AddColumn<int>(
                name: "WebinarHolderId",
                table: "Webinars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WebinarWebinarHolder",
                columns: table => new
                {
                    WebinarHoldersWebinarHolderId = table.Column<int>(type: "int", nullable: false),
                    WebinarsWebinarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebinarWebinarHolder", x => new { x.WebinarHoldersWebinarHolderId, x.WebinarsWebinarId });
                    table.ForeignKey(
                        name: "FK_WebinarWebinarHolder_WebinarHolders_WebinarHoldersWebinarHolderId",
                        column: x => x.WebinarHoldersWebinarHolderId,
                        principalTable: "WebinarHolders",
                        principalColumn: "WebinarHolderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WebinarWebinarHolder_Webinars_WebinarsWebinarId",
                        column: x => x.WebinarsWebinarId,
                        principalTable: "Webinars",
                        principalColumn: "WebinarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2023, 9, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2023, 8, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2023, 3, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2023, 7, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2023, 3, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2023, 5, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 15, 12, 20, 12, 521, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.CreateIndex(
                name: "IX_WebinarWebinarHolder_WebinarsWebinarId",
                table: "WebinarWebinarHolder",
                column: "WebinarsWebinarId");
        }
    }
}
