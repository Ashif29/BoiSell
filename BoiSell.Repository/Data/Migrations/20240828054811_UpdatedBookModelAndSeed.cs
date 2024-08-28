using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoiSell.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedBookModelAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Books",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ISBN", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 11, 48, 10, 685, DateTimeKind.Local).AddTicks(7213), "1f30e16c-a1e7-433c-af5d-1a665c1eb2a5", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ISBN", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 11, 48, 10, 685, DateTimeKind.Local).AddTicks(7232), "174cfa9e-e90c-4a33-adc0-fad756a7819d", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ISBN", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 11, 48, 10, 685, DateTimeKind.Local).AddTicks(7238), "cf3693a2-2252-425a-a33d-7d15ab8c104e", null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ISBN", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 11, 48, 10, 685, DateTimeKind.Local).AddTicks(7244), "f80ca38e-65a2-4155-aab0-aa64216d645c", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ISBN",
                value: "e8e5777a-0b90-4f8b-b5a5-a252bdee2fb4");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ISBN",
                value: "4663cae6-26ba-4e70-88f0-482ea599bd75");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ISBN",
                value: "b45741b1-6099-4dc2-89dd-33444769a8cd");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ISBN",
                value: "2e169ccf-735e-4406-b9d8-5c921fadc693");
        }
    }
}
