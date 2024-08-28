using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoiSell.Web.Migrations
{
    /// <inheritdoc />
    public partial class SavingEnumAsString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ISBN", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 2, 3, 490, DateTimeKind.Local).AddTicks(2522), "39f78952-762a-42aa-8700-18a026a72c3f", "Available" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ISBN", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 2, 3, 490, DateTimeKind.Local).AddTicks(2555), "6a2535e8-1061-40d2-adfc-fd8e6c9ad745", "Available" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ISBN", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 2, 3, 490, DateTimeKind.Local).AddTicks(2563), "26cd2bfa-1833-4ee0-8459-68a8f483aa96", "Available" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ISBN", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 13, 2, 3, 490, DateTimeKind.Local).AddTicks(2570), "5a85685f-590f-4c73-8db0-3f2d59fe8630", "Available" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ISBN", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 11, 48, 10, 685, DateTimeKind.Local).AddTicks(7213), "1f30e16c-a1e7-433c-af5d-1a665c1eb2a5", 0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ISBN", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 11, 48, 10, 685, DateTimeKind.Local).AddTicks(7232), "174cfa9e-e90c-4a33-adc0-fad756a7819d", 0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ISBN", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 11, 48, 10, 685, DateTimeKind.Local).AddTicks(7238), "cf3693a2-2252-425a-a33d-7d15ab8c104e", 0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ISBN", "Status" },
                values: new object[] { new DateTime(2024, 8, 28, 11, 48, 10, 685, DateTimeKind.Local).AddTicks(7244), "f80ca38e-65a2-4155-aab0-aa64216d645c", 0 });
        }
    }
}
