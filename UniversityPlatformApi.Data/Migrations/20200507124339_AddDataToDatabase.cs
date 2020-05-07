using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityPlatformApi.Migrations
{
    public partial class AddDataToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Universities",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Schools",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Schools",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "UniversityId", "Name" },
                values: new object[,]
                {
                    { 1, "Universidad Nacional Del Nordeste" },
                    { 2, "Universidad de la Defensa Nacional" },
                    { 3, "Universidad Austral" },
                    { 4, "Universidad Nacional del Arte (UNA)" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "Address", "Name", "UniversityId" },
                values: new object[,]
                {
                    { 1, "Av. Las Heras 727 - CP 3500 Resistencia, Chaco", "Arquitectura y Urbanismo", 1 },
                    { 2, "A. Illia 368. - CP 3500 Resistencia, Chaco.", "Artes, Diseño y Ciencias de la Cultura", 1 },
                    { 3, "Sargento Cabral 2131– CP 3400 Corrientes", "Ciencias Agrarias", 1 },
                    { 4, "Av. Las Heras 727 - CP 3500 Resistencia, Chaco", "Ciencias Económicas", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Universities",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Schools",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Schools",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);
        }
    }
}
