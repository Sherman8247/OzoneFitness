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
                values: new object[] { new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8098), new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8112), new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8339), new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8342), new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8442), new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8444), new DateTime(2025, 1, 15, 9, 20, 45, 637, DateTimeKind.Local).AddTicks(8444) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(2991), new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3004), new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3176), new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3179), new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3265), new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3267), new DateTime(2024, 12, 8, 16, 18, 15, 435, DateTimeKind.Local).AddTicks(3268) });
        }
    }
}
