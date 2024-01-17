using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class MakeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "infos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Iran");

            migrationBuilder.UpdateData(
                table: "infos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "France");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "infos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Reza");

            migrationBuilder.UpdateData(
                table: "infos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Amir");
        }
    }
}
