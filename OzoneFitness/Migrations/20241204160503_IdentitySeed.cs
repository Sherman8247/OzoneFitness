using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OzoneFitness.Migrations
{
    /// <inheritdoc />
    public partial class IdentitySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Customer_CustomerID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Gym_GymID",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Customer_CustomerID",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Trainer_TrainerID",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Trainer_TrainerID",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainer_Gym_GymID",
                table: "Trainer");

            migrationBuilder.RenameColumn(
                name: "TrainerID",
                table: "Trainer",
                newName: "TrainerId");

            migrationBuilder.RenameColumn(
                name: "GymID",
                table: "Trainer",
                newName: "GymId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Trainer",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Trainer_GymID",
                table: "Trainer",
                newName: "IX_Trainer_GymId");

            migrationBuilder.RenameColumn(
                name: "TrainerID",
                table: "Schedule",
                newName: "TrainerId");

            migrationBuilder.RenameColumn(
                name: "ScheduleID",
                table: "Schedule",
                newName: "ScheduleId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Schedule",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_TrainerID",
                table: "Schedule",
                newName: "IX_Schedule_TrainerId");

            migrationBuilder.RenameColumn(
                name: "GymID",
                table: "Gym",
                newName: "GymId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Gym",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TrainerID",
                table: "Feedback",
                newName: "TrainerId");

            migrationBuilder.RenameColumn(
                name: "FeedbackID",
                table: "Feedback",
                newName: "FeedbackId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Feedback",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Feedback",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_TrainerID",
                table: "Feedback",
                newName: "IX_Feedback_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_CustomerID",
                table: "Feedback",
                newName: "IX_Feedback_CustomerId");

            migrationBuilder.RenameColumn(
                name: "GymID",
                table: "Customer",
                newName: "GymId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customer",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customer",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_GymID",
                table: "Customer",
                newName: "IX_Customer_GymId");

            migrationBuilder.RenameColumn(
                name: "ScheduleID",
                table: "Booking",
                newName: "ScheduleId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Booking",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "Booking",
                newName: "BookingId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Booking",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_CustomerID",
                table: "Booking",
                newName: "IX_Booking_CustomerId");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedBy", "CustomerId", "DateCreated", "DateUpdated", "Email", "GymId", "MembershipStatus", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", 0, new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(398), new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(408), "Jonas@gmail.com", null, "Member", "Jonas", "System" },
                    { 2, "System", 0, new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(410), "Sherman@gmail.com", null, "Nil", "Sherman", "System" }
                });

            migrationBuilder.InsertData(
                table: "Gym",
                columns: new[] { "Id", "Address", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "GymId", "OperatingHours", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Pasir ris Mall", 150, "System", new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(582), new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(583), 0, "12", "System" },
                    { 2, "Tampines Mall", 200, "System", new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(584), new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(585), 0, "10", "System" }
                });

            migrationBuilder.InsertData(
                table: "Trainer",
                columns: new[] { "Id", "ContactInfo", "CreatedBy", "DateCreated", "DateUpdated", "GymId", "Name", "TrainerId", "UpdatedBy", "YearsOfExperience" },
                values: new object[,]
                {
                    { 1, "12345678", "System", new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(716), 0, "Mr Goh", 0, "System", 12 },
                    { 2, "87654321", "System", new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(718), new DateTime(2024, 12, 5, 0, 5, 3, 127, DateTimeKind.Local).AddTicks(718), 0, "Mr Tang", 0, "System", 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Gym_GymId",
                table: "Customer",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Customer_CustomerId",
                table: "Feedback",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Trainer_TrainerId",
                table: "Feedback",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Trainer_TrainerId",
                table: "Schedule",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainer_Gym_GymId",
                table: "Trainer",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Gym_GymId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Customer_CustomerId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Trainer_TrainerId",
                table: "Feedback");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Trainer_TrainerId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainer_Gym_GymId",
                table: "Trainer");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "Trainer",
                newName: "TrainerID");

            migrationBuilder.RenameColumn(
                name: "GymId",
                table: "Trainer",
                newName: "GymID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Trainer",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Trainer_GymId",
                table: "Trainer",
                newName: "IX_Trainer_GymID");

            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "Schedule",
                newName: "TrainerID");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "Schedule",
                newName: "ScheduleID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Schedule",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_TrainerId",
                table: "Schedule",
                newName: "IX_Schedule_TrainerID");

            migrationBuilder.RenameColumn(
                name: "GymId",
                table: "Gym",
                newName: "GymID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Gym",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "Feedback",
                newName: "TrainerID");

            migrationBuilder.RenameColumn(
                name: "FeedbackId",
                table: "Feedback",
                newName: "FeedbackID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Feedback",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Feedback",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_TrainerId",
                table: "Feedback",
                newName: "IX_Feedback_TrainerID");

            migrationBuilder.RenameIndex(
                name: "IX_Feedback_CustomerId",
                table: "Feedback",
                newName: "IX_Feedback_CustomerID");

            migrationBuilder.RenameColumn(
                name: "GymId",
                table: "Customer",
                newName: "GymID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customer",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_GymId",
                table: "Customer",
                newName: "IX_Customer_GymID");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "Booking",
                newName: "ScheduleID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Booking",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Booking",
                newName: "BookingID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Booking",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking",
                newName: "IX_Booking_CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Customer_CustomerID",
                table: "Booking",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Gym_GymID",
                table: "Customer",
                column: "GymID",
                principalTable: "Gym",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Customer_CustomerID",
                table: "Feedback",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Trainer_TrainerID",
                table: "Feedback",
                column: "TrainerID",
                principalTable: "Trainer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Trainer_TrainerID",
                table: "Schedule",
                column: "TrainerID",
                principalTable: "Trainer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainer_Gym_GymID",
                table: "Trainer",
                column: "GymID",
                principalTable: "Gym",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
