﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNews.Persistence.Migrations.MSSQL
{
    public partial class addedoptionfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "DynamicFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2023, 10, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2023, 9, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2023, 4, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2023, 8, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2023, 4, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2023, 6, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 51, 40, 907, DateTimeKind.Utc).AddTicks(1571));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Options",
                table: "DynamicFields");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2023, 10, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2023, 9, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2023, 4, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2023, 8, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2023, 4, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2023, 6, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 49, 37, 370, DateTimeKind.Utc).AddTicks(6103));
        }
    }
}