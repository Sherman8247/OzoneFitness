using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OzoneFitness.Migrations
{
    /// <inheritdoc />
    public partial class AddTrainerImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f30bb7fd-66c3-4384-abb0-7b136839ce02", "AQAAAAIAAYagAAAAEMNhgG1DOhHOKeLCyervo819Lighyf7BlLC0bFMY7vmQuHSmUZvsGtaQeiSB+orSLg==", "4d2df2f7-f3e5-443a-a440-99bc390e1c43" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(5771), new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(5791), new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(6307), new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(6311), new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(6452), new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(6454), new DateTime(2025, 2, 9, 1, 13, 50, 809, DateTimeKind.Local).AddTicks(6454) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c5985a0-4402-4ab8-a500-0a50185d7830", "AQAAAAIAAYagAAAAENfPUUz624Y8i3grgwvCSCYMe0z9OqrOet9ESPBuvwnuos1luWC6z32icoGFyA4Yhw==", "cd83a659-d827-45f4-8fb7-ebb79a01875d" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(561), new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(575), new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(759), new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(761), new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(901), new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(904), new DateTime(2025, 2, 9, 1, 13, 10, 182, DateTimeKind.Local).AddTicks(904) });
        }
    }
}
