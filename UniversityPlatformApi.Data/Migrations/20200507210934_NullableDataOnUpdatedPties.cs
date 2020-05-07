using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityPlatformApi.Migrations
{
    public partial class NullableDataOnUpdatedPties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "User",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "User",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Universities",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Universities",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Schools",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Schools",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 18, 9, 34, 28, DateTimeKind.Local).AddTicks(8136), null, null });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 18, 9, 34, 28, DateTimeKind.Local).AddTicks(8202), null, null });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 18, 9, 34, 28, DateTimeKind.Local).AddTicks(8205), null, null });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 18, 9, 34, 28, DateTimeKind.Local).AddTicks(8207), null, null });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 18, 9, 34, 27, DateTimeKind.Local).AddTicks(3764), null, null });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 18, 9, 34, 27, DateTimeKind.Local).AddTicks(3843), null, null });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 18, 9, 34, 27, DateTimeKind.Local).AddTicks(3846), null, null });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 18, 9, 34, 27, DateTimeKind.Local).AddTicks(3848), null, null });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 18, 9, 34, 11, DateTimeKind.Local).AddTicks(5105), "AQAAAAEAACcQAAAAEO0tDi2ucgn26a8pyQeKBX+AnIKO+gzDYjOJZPSSZb6i1y8Gyb5xJ6hsiUq0zYtnVg==", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Universities",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Universities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Schools",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                table: "Schools",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 75, DateTimeKind.Local).AddTicks(838), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 75, DateTimeKind.Local).AddTicks(929), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 75, DateTimeKind.Local).AddTicks(932), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 75, DateTimeKind.Local).AddTicks(933), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 73, DateTimeKind.Local).AddTicks(4897), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 73, DateTimeKind.Local).AddTicks(4979), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 73, DateTimeKind.Local).AddTicks(4982), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 73, DateTimeKind.Local).AddTicks(4984), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new DateTime(2020, 5, 7, 17, 6, 30, 57, DateTimeKind.Local).AddTicks(1284), "AQAAAAEAACcQAAAAEIpqF2vRb4zSliXJrRaIFua9S75fIqTrgSmO57OaQSBoAjOl1A7QFHCVZ1zCtXlQig==", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
