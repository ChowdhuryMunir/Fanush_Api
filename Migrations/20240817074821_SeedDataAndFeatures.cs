using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAndFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "ClockInOuts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EarlyDepartureReason",
                table: "ClockInOuts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HalfDayType",
                table: "AbsenceReports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    GoalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignedByUserId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.GoalId);
                    table.ForeignKey(
                        name: "FK_Goals_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceReports",
                columns: table => new
                {
                    PerformanceReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EvaluatorId = table.Column<int>(type: "int", nullable: false),
                    EvaluationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerformanceScore = table.Column<int>(type: "int", nullable: true),
                    GoalsMet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Strengths = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreasForImprovement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achievements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevelopmentPlan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverallRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewPeriodStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionItems = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceReports", x => x.PerformanceReportId);
                    table.ForeignKey(
                        name: "FK_PerformanceReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceReviews",
                columns: table => new
                {
                    PerformanceReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerformanceRating = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceReviews", x => x.PerformanceReviewId);
                    table.ForeignKey(
                        name: "FK_PerformanceReviews_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
    name: "DevelopmentPlans",
    columns: table => new
    {
        DevelopmentPlanId = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        EmployeeId = table.Column<int>(type: "int", nullable: false),
        GoalId = table.Column<int>(type: "int", nullable: false),
        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
        TargetCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        Status = table.Column<int>(type: "int", nullable: false),
        Progress = table.Column<int>(type: "int", nullable: false),
        IsActive = table.Column<bool>(type: "bit", nullable: false),
        Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
        Resources = table.Column<string>(type: "nvarchar(max)", nullable: false),
        CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_DevelopmentPlans", x => x.DevelopmentPlanId);
        table.ForeignKey(
            name: "FK_DevelopmentPlans_Employees_EmployeeId",
            column: x => x.EmployeeId,
            principalTable: "Employees",
            principalColumn: "EmployeeId",
            onDelete: ReferentialAction.NoAction);
        table.ForeignKey(
            name: "FK_DevelopmentPlans_Goals_GoalId",
            column: x => x.GoalId,
            principalTable: "Goals",
            principalColumn: "GoalId",
            onDelete: ReferentialAction.NoAction);
    });

            migrationBuilder.InsertData(
                table: "AbsenceReports",
                columns: new[] { "AbsenceReportId", "ApprovedDate", "Approver", "EmployeeId", "EndDate", "HalfDayType", "IsHalfDay", "IsPaid", "Reason", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 1, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, "Medical Leave", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 2, null, "Jane Smith", 2, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning", true, false, "Personal Leave", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 3, new DateTime(2024, 8, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), "Emily Brown", 3, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, "Vacation", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 4, new DateTime(2024, 8, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Chris Evans", 4, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afternoon", true, true, "Medical Appointment", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 5, null, "Anna Taylor", 5, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, "Family Emergency", new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 6, new DateTime(2024, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "Robert Downey", 6, new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning", true, true, "Childcare", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 7, new DateTime(2024, 8, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), "Scarlett Johansson", 7, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afternoon", true, false, "Study Leave", new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 8, new DateTime(2024, 8, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), "Mark Ruffalo", 8, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, "Holiday", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 9, null, "Natalie Portman", 9, new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning", true, false, "Sick Leave", new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 10, new DateTime(2024, 9, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), "Chris Hemsworth", 10, new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, "Workshop Attendance", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" }
                });

            migrationBuilder.InsertData(
                table: "ClockInOuts",
                columns: new[] { "ClockInOutId", "Action", "ApprovedBy", "ClockInTime", "ClockOutTime", "EarlyDepartureReason", "EmployeeId", "IsActive", "IsEarlyDeparture", "IsLateArrival", "IsOvertime", "IsWorkday", "LateArrivalReason", "Location", "Notes", "OvertimeHours", "Timestamp" },
                values: new object[,]
                {
                    { 1, "ClockIn", "John Doe", new DateTime(2024, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, false, false, false, true, "", "Office A", "Normal day", 0m, new DateTime(2024, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "ClockIn", "Jane Smith", new DateTime(2024, 8, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 2, true, false, true, true, true, "Traffic", "Office B", "Late arrival due to traffic", 0.5m, new DateTime(2024, 8, 2, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "ClockIn", "Emily Johnson", new DateTime(2024, 8, 3, 7, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 16, 45, 0, 0, DateTimeKind.Unspecified), null, 3, true, false, false, false, true, "", "Remote", "Working from home", 0m, new DateTime(2024, 8, 3, 7, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "ClockIn", "Michael Brown", new DateTime(2024, 8, 4, 8, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 17, 15, 0, 0, DateTimeKind.Unspecified), null, 4, true, false, true, true, true, "Doctor's appointment", "Office C", "Late due to doctor's appointment", 0.25m, new DateTime(2024, 8, 4, 8, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "ClockIn", "David Wilson", new DateTime(2024, 8, 5, 7, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 17, 5, 0, 0, DateTimeKind.Unspecified), null, 5, true, false, false, true, true, "", "Office A", "Arrived early", 0.17m, new DateTime(2024, 8, 5, 7, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "ClockIn", "John Doe", new DateTime(2024, 8, 6, 8, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 16, 5, 0, 0, DateTimeKind.Unspecified), null, 6, true, false, true, false, true, "Family emergency", "Remote", "Late due to family emergency", 0m, new DateTime(2024, 8, 6, 8, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "ClockIn", "Jane Smith", new DateTime(2024, 8, 7, 8, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 17, 10, 0, 0, DateTimeKind.Unspecified), null, 7, true, false, true, true, true, "Transport issues", "Office B", "Slight delay due to transport issues", 0.17m, new DateTime(2024, 8, 7, 8, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "ClockIn", "Emily Johnson", new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 8, true, false, false, false, true, "", "Office C", "Normal clock-in", 0m, new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "ClockIn", "Michael Brown", new DateTime(2024, 8, 9, 7, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 16, 50, 0, 0, DateTimeKind.Unspecified), null, 9, true, false, false, true, true, "", "Remote", "Early clock-in", 0.17m, new DateTime(2024, 8, 9, 7, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "ClockIn", "David Wilson", new DateTime(2024, 8, 10, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 17, 20, 0, 0, DateTimeKind.Unspecified), null, 10, true, false, true, true, true, "Personal reasons", "Office A", "Late due to personal reasons", 0.17m, new DateTime(2024, 8, 10, 8, 20, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4039), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4048), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4057), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4068), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4074), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4080), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4086), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4091), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4097), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4153), new DateTime(2024, 8, 17, 7, 48, 18, 914, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.CreateIndex(
                name: "IX_PayrollIntegrations_EmployeeId",
                table: "PayrollIntegrations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentPlans_EmployeeId",
                table: "DevelopmentPlans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentPlans_GoalId",
                table: "DevelopmentPlans",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_EmployeeId",
                table: "Goals",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReports_EmployeeId",
                table: "PerformanceReports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReviews_EmployeeId",
                table: "PerformanceReviews",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PayrollIntegrations_Employees_EmployeeId",
                table: "PayrollIntegrations",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PayrollIntegrations_Employees_EmployeeId",
                table: "PayrollIntegrations");

            migrationBuilder.DropTable(
                name: "DevelopmentPlans");

            migrationBuilder.DropTable(
                name: "PerformanceReports");

            migrationBuilder.DropTable(
                name: "PerformanceReviews");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropIndex(
                name: "IX_PayrollIntegrations_EmployeeId",
                table: "PayrollIntegrations");

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClockInOuts",
                keyColumn: "ClockInOutId",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "ClockInOuts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EarlyDepartureReason",
                table: "ClockInOuts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HalfDayType",
                table: "AbsenceReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
