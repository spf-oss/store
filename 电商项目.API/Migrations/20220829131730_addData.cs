using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace 电商项目.API.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Description", "DiscountPresent", "Feature", "Fees", "Notes", "OriginaPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("dd9ffdc5-062f-423c-b870-ada8c59e89bb"), new DateTime(2022, 8, 29, 13, 17, 30, 672, DateTimeKind.Utc).AddTicks(1756), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "测试数据", 0.0, "", "", "", 0m, "TestTitle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("dd9ffdc5-062f-423c-b870-ada8c59e89bb"));
        }
    }
}
