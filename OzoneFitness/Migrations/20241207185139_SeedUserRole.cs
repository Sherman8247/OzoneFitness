using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OzoneFitness.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(8818), new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(8833), new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(9036), new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(9038), new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(9215), new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(9217), new DateTime(2024, 12, 8, 2, 51, 38, 467, DateTimeKind.Local).AddTicks(9218) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(1909), new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(2133), new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(2135), new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(2331), new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 12, 7, 1, 32, 3, 417, DateTimeKind.Local).AddTicks(2333) });
        }
    }
}
