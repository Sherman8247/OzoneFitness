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
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Trainer",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af3d2519-5a2b-4c80-86ac-3f75e6757199", "AQAAAAIAAYagAAAAEJdLB0+zk95Dc56bdmDKpa4YlY4K+DYWlwbHNo06JZcOF4jAtDAOt8W7UFIK7C6CbA==", "f2530efb-80fe-476a-b9fe-22f08f0dc2b8" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3531), new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3544), new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3750), new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3752), new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3845), new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3845), null });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3847), new DateTime(2025, 2, 8, 15, 36, 10, 415, DateTimeKind.Local).AddTicks(3847), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Trainer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d27b722-8e4f-44af-a84e-34dc8efaa626", "AQAAAAIAAYagAAAAEFmHtEfXvKTB9oCX+gabk1ADZ49XcmlzC0+f7btCqb8VKAnNwVxuQ0Febu3fF96KoQ==", "d0e67b96-19d6-4661-a5bd-3d1008ffb767" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5483), new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5496), new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5679), new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5682), new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5776), new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5778), new DateTime(2025, 2, 7, 22, 18, 4, 44, DateTimeKind.Local).AddTicks(5779) });
        }
    }
}
