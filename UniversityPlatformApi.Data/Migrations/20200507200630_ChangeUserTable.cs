using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityPlatformApi.Migrations
{
    public partial class ChangeUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "User",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "User",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 17, 6, 30, 75, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 17, 6, 30, 75, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 17, 6, 30, 75, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 17, 6, 30, 75, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 17, 6, 30, 73, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 17, 6, 30, 73, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 17, 6, 30, 73, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 17, 6, 30, 73, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 57, DateTimeKind.Local).AddTicks(1284), "Lisandro", "Chichi", "AQAAAAEAACcQAAAAEIpqF2vRb4zSliXJrRaIFua9S75fIqTrgSmO57OaQSBoAjOl1A7QFHCVZ1zCtXlQig==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 12, 21, 13, 925, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 12, 21, 13, 925, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 12, 21, 13, 925, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 12, 21, 13, 925, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 12, 21, 13, 923, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 12, 21, 13, 923, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 12, 21, 13, 923, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 5, 7, 12, 21, 13, 923, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name", "Password" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 21, 13, 896, DateTimeKind.Local).AddTicks(1865), "Lisandro", "AQAAAAEAACcQAAAAEA9P9EeE8stts3Zxh1LOQk/ZHRkDy31FAc8+VZ/Tr0kDyxwfyZU7ScyCFm91lXgsUQ==" });
        }
    }
}
