using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityPlatformApi.Migrations
{
    public partial class AddUserCredsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "User",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Universities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Universities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Universities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Universities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Schools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Schools",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Schools",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Schools",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { 1, new DateTime(2020, 5, 7, 12, 21, 13, 925, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { 1, new DateTime(2020, 5, 7, 12, 21, 13, 925, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { 1, new DateTime(2020, 5, 7, 12, 21, 13, 925, DateTimeKind.Local).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { 1, new DateTime(2020, 5, 7, 12, 21, 13, 925, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { 1, new DateTime(2020, 5, 7, 12, 21, 13, 923, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { 1, new DateTime(2020, 5, 7, 12, 21, 13, 923, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { 1, new DateTime(2020, 5, 7, 12, 21, 13, 923, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { 1, new DateTime(2020, 5, 7, 12, 21, 13, 923, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "Email", "Password", "Username" },
                values: new object[] { 1, new DateTime(2020, 5, 7, 12, 21, 13, 896, DateTimeKind.Local).AddTicks(1865), "lisandrochichi@gmail.com", "AQAAAAEAACcQAAAAEA9P9EeE8stts3Zxh1LOQk/ZHRkDy31FAc8+VZ/Tr0kDyxwfyZU7ScyCFm91lXgsUQ==", "LisandroAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Universities");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Schools");
        }
    }
}
