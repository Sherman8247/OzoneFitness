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
                values: new object[] { "670692b1-302b-4ffc-930f-0aa9b182ffd1", "AQAAAAIAAYagAAAAEEv1TiwL2UPoov61a4eIiEY9Ttu0He9ijOoi9+kQYoUoTvW/vDV5FFkUBzDFm3BToQ==", "ba57ba11-4b15-4dd6-a359-6ec68339637d" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8109), new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8122), new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8361), new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8364), new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8457), new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8457), null });

            migrationBuilder.UpdateData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Image" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8458), new DateTime(2025, 2, 8, 23, 22, 32, 100, DateTimeKind.Local).AddTicks(8459), null });
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
