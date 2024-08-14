using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInEmployeeClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ClockInOut",
                columns: table => new
                {
                    ClockInOutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClockInTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClockOutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLateArrival = table.Column<bool>(type: "bit", nullable: false),
                    IsEarlyDeparture = table.Column<bool>(type: "bit", nullable: false),
                    IsWorkday = table.Column<bool>(type: "bit", nullable: false),
                    OvertimeHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsOvertime = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LateArrivalReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EarlyDepartureReason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockInOut", x => x.ClockInOutId);
                    table.ForeignKey(
                        name: "FK_ClockInOut_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leave",
                columns: table => new
                {
                    LeaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Approver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPaidLeave = table.Column<bool>(type: "bit", nullable: false),
                    LeaveCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave", x => x.LeaveId);
                    table.ForeignKey(
                        name: "FK_Leave_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(547), 1, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(556), 2, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(562), 3, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(567), 4, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(571), 5, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(577), 6, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(581), 7, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(629), 8, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(634), 9, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(638), 10, new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.CreateIndex(
                name: "IX_ClockInOut_EmployeeId",
                table: "ClockInOut",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Leave_EmployeeId",
                table: "Leave",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "JobTitleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "ClockInOut");

            migrationBuilder.DropTable(
                name: "Leave");

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5462), "Software Engineer", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5469), "Project Manager", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5475), "HR Manager", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5479), "Business Analyst", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5483), "Operations Manager", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5487), "Marketing Manager", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5491), "Finance Manager", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5495), "Content Strategist", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5499), "Data Scientist", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "JobTitle", "JobTitleId", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5503), "UX Designer", null, new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "JobTitleId");
        }
    }
}
