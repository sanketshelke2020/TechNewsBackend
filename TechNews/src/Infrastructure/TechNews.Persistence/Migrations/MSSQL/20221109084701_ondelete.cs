using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechNews.Persistence.Migrations.MSSQL
{
    public partial class ondelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleSubCategories_ArticleSubCategoryId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleCategoryId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleSubCategoryId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "ArticleCategoryId1",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArticleSubCategoryId1",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2023, 9, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2023, 8, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2023, 3, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2023, 7, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2023, 3, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2023, 5, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 47, 0, 690, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCategoryId1",
                table: "Articles",
                column: "ArticleCategoryId1",
                unique: true,
                filter: "[ArticleCategoryId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleSubCategoryId",
                table: "Articles",
                column: "ArticleSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleSubCategoryId1",
                table: "Articles",
                column: "ArticleSubCategoryId1",
                unique: true,
                filter: "[ArticleSubCategoryId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId",
                principalTable: "ArticleCategories",
                principalColumn: "ArticleCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleCategories_ArticleCategoryId1",
                table: "Articles",
                column: "ArticleCategoryId1",
                principalTable: "ArticleCategories",
                principalColumn: "ArticleCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleSubCategories_ArticleSubCategoryId",
                table: "Articles",
                column: "ArticleSubCategoryId",
                principalTable: "ArticleSubCategories",
                principalColumn: "ArticleSubCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleSubCategories_ArticleSubCategoryId1",
                table: "Articles",
                column: "ArticleSubCategoryId1",
                principalTable: "ArticleSubCategories",
                principalColumn: "ArticleSubCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleCategories_ArticleCategoryId1",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleSubCategories_ArticleSubCategoryId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ArticleSubCategories_ArticleSubCategoryId1",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleCategoryId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleCategoryId1",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleSubCategoryId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArticleSubCategoryId1",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArticleCategoryId1",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArticleSubCategoryId1",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("1babd057-e980-4cb3-9cd2-7fdd9e525668"),
                column: "Date",
                value: new DateTime(2023, 9, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("3448d5a4-0f72-4dd7-bf15-c14a46b26c00"),
                column: "Date",
                value: new DateTime(2023, 8, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("62787623-4c52-43fe-b0c9-b7044fb5929b"),
                column: "Date",
                value: new DateTime(2023, 3, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("adc42c09-08c1-4d2c-9f96-2d15bb1af299"),
                column: "Date",
                value: new DateTime(2023, 7, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("b419a7ca-3321-4f38-be8e-4d7b6a529319"),
                column: "Date",
                value: new DateTime(2023, 3, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                column: "Date",
                value: new DateTime(2023, 5, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("ba0eb0ef-b69b-46fd-b8e2-41b4178ae7cb"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                column: "OrderPlaced",
                value: new DateTime(2022, 11, 9, 8, 46, 11, 861, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleSubCategoryId",
                table: "Articles",
                column: "ArticleSubCategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId",
                principalTable: "ArticleCategories",
                principalColumn: "ArticleCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ArticleSubCategories_ArticleSubCategoryId",
                table: "Articles",
                column: "ArticleSubCategoryId",
                principalTable: "ArticleSubCategories",
                principalColumn: "ArticleSubCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
