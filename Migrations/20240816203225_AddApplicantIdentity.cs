using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicantIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClockInOut_Employees_EmployeeId",
                table: "ClockInOut");

            migrationBuilder.DropForeignKey(
                name: "FK_Leave_Employees_EmployeeId",
                table: "Leave");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leave",
                table: "Leave");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClockInOut",
                table: "ClockInOut");

            migrationBuilder.RenameTable(
                name: "Leave",
                newName: "Leaves");

            migrationBuilder.RenameTable(
                name: "ClockInOut",
                newName: "ClockInOuts");

            migrationBuilder.RenameIndex(
                name: "IX_Leave_EmployeeId",
                table: "Leaves",
                newName: "IX_Leaves_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_ClockInOut_EmployeeId",
                table: "ClockInOuts",
                newName: "IX_ClockInOuts_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "InterviewType",
                table: "Interviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Education_Degree",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Education_Institution",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Education_PassingYear",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Education_Result",
                table: "Applicants",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkExperience_Company",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkExperience_Duration",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkExperience_Position",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leaves",
                table: "Leaves",
                column: "LeaveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClockInOuts",
                table: "ClockInOuts",
                column: "ClockInOutId");

            migrationBuilder.CreateTable(
                name: "AbsenceReports",
                columns: table => new
                {
                    AbsenceReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsHalfDay = table.Column<bool>(type: "bit", nullable: false),
                    HalfDayType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsenceReports", x => x.AbsenceReportId);
                    table.ForeignKey(
                        name: "FK_AbsenceReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Overtimes",
                columns: table => new
                {
                    OvertimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hours = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OvertimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachmentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Overtimes", x => x.OvertimeId);
                    table.ForeignKey(
                        name: "FK_Overtimes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayrollIntegrations",
                columns: table => new
                {
                    PayrollIntegrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayrollSystemId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IntegrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntegrationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PayPeriodStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayPeriodEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayFrequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deductions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollIntegrations", x => x.PayrollIntegrationId);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8832), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8838), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8845), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8854), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8860), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8866), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8871), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8876), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8880), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8886), new DateTime(2024, 8, 16, 20, 32, 24, 512, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.CreateIndex(
                name: "IX_AbsenceReports_EmployeeId",
                table: "AbsenceReports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Overtimes_EmployeeId",
                table: "Overtimes",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClockInOuts_Employees_EmployeeId",
                table: "ClockInOuts",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaves_Employees_EmployeeId",
                table: "Leaves",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClockInOuts_Employees_EmployeeId",
                table: "ClockInOuts");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaves_Employees_EmployeeId",
                table: "Leaves");

            migrationBuilder.DropTable(
                name: "AbsenceReports");

            migrationBuilder.DropTable(
                name: "Overtimes");

            migrationBuilder.DropTable(
                name: "PayrollIntegrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leaves",
                table: "Leaves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClockInOuts",
                table: "ClockInOuts");

            migrationBuilder.DropColumn(
                name: "InterviewType",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "Education_Degree",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Education_Institution",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Education_PassingYear",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Education_Result",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "WorkExperience_Company",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "WorkExperience_Duration",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "WorkExperience_Position",
                table: "Applicants");

            migrationBuilder.RenameTable(
                name: "Leaves",
                newName: "Leave");

            migrationBuilder.RenameTable(
                name: "ClockInOuts",
                newName: "ClockInOut");

            migrationBuilder.RenameIndex(
                name: "IX_Leaves_EmployeeId",
                table: "Leave",
                newName: "IX_Leave_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_ClockInOuts_EmployeeId",
                table: "ClockInOut",
                newName: "IX_ClockInOut_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leave",
                table: "Leave",
                column: "LeaveId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClockInOut",
                table: "ClockInOut",
                column: "ClockInOutId");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1558), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1566), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1571), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1576), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1581), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1586), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1592), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1596), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1601), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1606), new DateTime(2024, 8, 16, 10, 52, 11, 976, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.AddForeignKey(
                name: "FK_ClockInOut_Employees_EmployeeId",
                table: "ClockInOut",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leave_Employees_EmployeeId",
                table: "Leave",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
