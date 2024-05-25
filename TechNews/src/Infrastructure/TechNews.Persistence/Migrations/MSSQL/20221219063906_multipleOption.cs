using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNews.Persistence.Migrations.MSSQL
{
    public partial class multipleOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionMasterId",
                table: "DynamicFormDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FieldType",
                table: "DynamicFields",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsNumber",
                table: "DynamicFields",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "DynamicFormMultipleOptions",
                columns: table => new
                {
                    DynamicFormMultipleOptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DynamicFieldId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicFormMultipleOptions", x => x.DynamicFormMultipleOptionId);
                    table.ForeignKey(
                        name: "FK_DynamicFormMultipleOptions_DynamicFields_DynamicFieldId",
                        column: x => x.DynamicFieldId,
                        principalTable: "DynamicFields",
                        principalColumn: "DynamicFieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2023, 10, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2023, 9, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2023, 4, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2023, 8, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2023, 4, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2023, 6, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 19, 6, 39, 5, 812, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.CreateIndex(
                name: "IX_DynamicFormDatas_SectionMasterId",
                table: "DynamicFormDatas",
                column: "SectionMasterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DynamicFormMultipleOptions_DynamicFieldId",
                table: "DynamicFormMultipleOptions",
                column: "DynamicFieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicFormDatas_SectionMasters_SectionMasterId",
                table: "DynamicFormDatas",
                column: "SectionMasterId",
                principalTable: "SectionMasters",
                principalColumn: "SectionMasterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DynamicFormDatas_SectionMasters_SectionMasterId",
                table: "DynamicFormDatas");

            migrationBuilder.DropTable(
                name: "DynamicFormMultipleOptions");

            migrationBuilder.DropIndex(
                name: "IX_DynamicFormDatas_SectionMasterId",
                table: "DynamicFormDatas");

            migrationBuilder.DropColumn(
                name: "SectionMasterId",
                table: "DynamicFormDatas");

            migrationBuilder.DropColumn(
                name: "FieldType",
                table: "DynamicFields");

            migrationBuilder.DropColumn(
                name: "IsNumber",
                table: "DynamicFields");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2023, 10, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2023, 9, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2023, 4, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2023, 8, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2023, 4, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2023, 6, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2022, 12, 16, 12, 50, 9, 682, DateTimeKind.Utc).AddTicks(8480));
        }
    }
}
