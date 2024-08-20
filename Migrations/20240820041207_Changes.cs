using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Hours",
                table: "Overtimes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<decimal>(
                name: "NumberOfDays",
                table: "Leaves",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DaysAbsent",
                table: "AbsenceReports",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "PayrollCalculations",
                columns: table => new
                {
                    PayrollCalcuationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicalAllowence = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConveyanceAllowence = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherAllowence = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeductedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollCalculations", x => x.PayrollCalcuationId);
                    table.ForeignKey(
                        name: "FK_PayrollCalculations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 1,
                columns: new[] { "ApprovedDate", "DaysAbsent", "EndDate", "HalfDayType" },
                values: new object[] { new DateTime(2024, 8, 3, 10, 30, 0, 0, DateTimeKind.Unspecified), 2.0m, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "None" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 2,
                columns: new[] { "ApprovedDate", "DaysAbsent", "EndDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 7, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), 0.5m, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 3,
                columns: new[] { "ApprovedDate", "Approver", "DaysAbsent", "EndDate", "HalfDayType", "IsPaid", "Reason", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 8, 6, 14, 15, 0, 0, DateTimeKind.Unspecified), "John Doe", 3.0m, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, "Family Emergency", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 4,
                columns: new[] { "ApprovedDate", "Approver", "DaysAbsent", "EndDate", "HalfDayType", "IsHalfDay", "Reason", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 2.0m, new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, "Sick Leave", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 5,
                columns: new[] { "ApprovedDate", "Approver", "DaysAbsent", "EndDate", "HalfDayType", "IsHalfDay", "Reason", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 8, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 0.5m, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afternoon", true, "Doctor's Appointment", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 6,
                columns: new[] { "ApprovedDate", "Approver", "DaysAbsent", "EndDate", "HalfDayType", "IsHalfDay", "Reason", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 9, 30, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 2.0m, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, "Vacation", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 7,
                columns: new[] { "ApprovedDate", "Approver", "DaysAbsent", "EndDate", "HalfDayType", "IsHalfDay", "IsPaid", "Reason", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 2.0m, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, true, "Jury Duty", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 8,
                columns: new[] { "ApprovedDate", "Approver", "DaysAbsent", "EndDate", "HalfDayType", "IsHalfDay", "IsPaid", "Reason", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 8, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 0.5m, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning", true, false, "Bereavement Leave", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 9,
                columns: new[] { "ApprovedDate", "Approver", "DaysAbsent", "EndDate", "HalfDayType", "IsHalfDay", "Reason", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 7, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), "John Doe", 2.0m, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, "Travel", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 10,
                columns: new[] { "ApprovedDate", "Approver", "DaysAbsent", "EndDate", "HalfDayType", "Reason", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 45, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 2.0m, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", "Training", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9028), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9036), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9044), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9050), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9056), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9062), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9067), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9086), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9092), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9097), new DateTime(2024, 8, 20, 4, 12, 4, 51, DateTimeKind.Utc).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                columns: new[] { "ApprovalComments", "ApprovalDate", "EndDate", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason" },
                values: new object[] { "Take care", new DateTime(2024, 7, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "Sick Leave", 3.0m, "Fever and cold" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 2,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "IsPaidLeave", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[] { "Enjoy your time", new DateTime(2024, 7, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), "John Doe", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Vacation Leave", "Vacation", 6.0m, "Family vacation", "Jane Smith", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "IsActive", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[] { "Pending approval", new DateTime(2024, 8, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Maternity Leave", "Maternity Leave", 9.0m, "Maternity", "Emily Clark", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Condolences", new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bereavement Leave", "Bereavement Leave", 6.0m, "Loss of family member", "Michael Brown", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "IsPaidLeave", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Get well soon", new DateTime(2024, 7, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), "Jane Smith", new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sick Leave", "Sick Leave", 2.0m, "Migraine", "Sarah Johnson", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 6,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "NumberOfDays", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[] { "Safe travels", new DateTime(2024, 8, 15, 11, 30, 0, 0, DateTimeKind.Unspecified), "John Doe", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vacation Leave", 6.0m, "Holiday trip", "David Williams", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Take rest", new DateTime(2024, 7, 29, 14, 45, 0, 0, DateTimeKind.Unspecified), "Jane Smith", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "Sick Leave", 2.0m, "Back pain", "James White", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 8,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[] { "Congrats!", new DateTime(2024, 9, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paternity Leave", "Paternity Leave", 15.0m, "Newborn care", "Robert Green", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Take care", new DateTime(2024, 8, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), "Jane Smith", new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sick Leave", "Sick Leave", 3.0m, "Flu", "William Black", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "IsPaidLeave", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Enjoy your time off", new DateTime(2024, 8, 20, 12, 15, 0, 0, DateTimeKind.Unspecified), "John Doe", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Vacation Leave", "Vacation", 6.0m, "Beach holiday", "Jessica King", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9554), 4.5m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9558), 3.0m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9562), 2.0m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9570), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9571), 5.0m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9574), 6.0m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9578), 4.0m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9581), 2.5m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9585), 3.5m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9588), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9589), 5.0m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9592), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9592), 4.5m, new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 12, 4, 52, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.CreateIndex(
                name: "IX_PayrollCalculations_EmployeeId",
                table: "PayrollCalculations",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PayrollCalculations");

            migrationBuilder.DropColumn(
                name: "NumberOfDays",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "DaysAbsent",
                table: "AbsenceReports");

            migrationBuilder.AlterColumn<double>(
                name: "Hours",
                table: "Overtimes",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 1,
                columns: new[] { "ApprovedDate", "EndDate", "HalfDayType" },
                values: new object[] { new DateTime(2024, 8, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 2,
                columns: new[] { "ApprovedDate", "EndDate", "StartDate", "Status" },
                values: new object[] { null, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 3,
                columns: new[] { "ApprovedDate", "Approver", "EndDate", "HalfDayType", "IsPaid", "Reason", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), "Emily Brown", new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "Vacation", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 4,
                columns: new[] { "ApprovedDate", "Approver", "EndDate", "HalfDayType", "IsHalfDay", "Reason", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), "Chris Evans", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afternoon", true, "Medical Appointment", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 5,
                columns: new[] { "ApprovedDate", "Approver", "EndDate", "HalfDayType", "IsHalfDay", "Reason", "StartDate", "Status" },
                values: new object[] { null, "Anna Taylor", new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Family Emergency", new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 6,
                columns: new[] { "ApprovedDate", "Approver", "EndDate", "HalfDayType", "IsHalfDay", "Reason", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "Robert Downey", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning", true, "Childcare", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 7,
                columns: new[] { "ApprovedDate", "Approver", "EndDate", "HalfDayType", "IsHalfDay", "IsPaid", "Reason", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), "Scarlett Johansson", new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afternoon", true, false, "Study Leave", new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 8,
                columns: new[] { "ApprovedDate", "Approver", "EndDate", "HalfDayType", "IsHalfDay", "IsPaid", "Reason", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), "Mark Ruffalo", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, "Holiday", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 9,
                columns: new[] { "ApprovedDate", "Approver", "EndDate", "HalfDayType", "IsHalfDay", "Reason", "StartDate", "Status" },
                values: new object[] { null, "Natalie Portman", new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning", true, "Sick Leave", new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" });

            migrationBuilder.UpdateData(
                table: "AbsenceReports",
                keyColumn: "AbsenceReportId",
                keyValue: 10,
                columns: new[] { "ApprovedDate", "Approver", "EndDate", "HalfDayType", "Reason", "StartDate" },
                values: new object[] { new DateTime(2024, 9, 9, 10, 15, 0, 0, DateTimeKind.Unspecified), "Chris Hemsworth", new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Workshop Attendance", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(4983), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5022), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5040), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5058), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5074), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5115), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5123), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5145), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5155), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5164), new DateTime(2024, 8, 19, 17, 4, 19, 909, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                columns: new[] { "ApprovalComments", "ApprovalDate", "EndDate", "LeaveCategory", "LeaveType", "Reason" },
                values: new object[] { "Approved", new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual", "Vacation", "Annual vacation" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 2,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "IsPaidLeave", "LeaveCategory", "LeaveType", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[] { null, null, null, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Medical", "Sick", "Medical reasons", "Alice Johnson", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "IsActive", "LeaveCategory", "LeaveType", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[] { "Approved", new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5747), "Michael Brown", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Maternity", "Maternity", "Childbirth", "Emily Davis", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "LeaveType", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Approved", new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5752), "Sarah Johnson", new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Personal", "Personal", "Personal matters", "David Wilson", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "IsPaidLeave", "LeaveCategory", "LeaveType", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Approved", new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5756), "Robert Brown", new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Unpaid", "Unpaid", "Extended leave", "Jessica Lee", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 6,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[] { null, null, null, new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual", "No coverage available", "Mark Taylor", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denied" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "LeaveType", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Approved", new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5764), "Olivia White", new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medical", "Sick", "Flu", "Anna Scott", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 8,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "LeaveType", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[] { null, null, null, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Personal", "Personal", "Family event", "John Martin", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "LeaveCategory", "LeaveType", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Approved", new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5772), "James Miller", new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maternity", "Maternity", "Childbirth", "Laura Clark", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                columns: new[] { "ApprovalComments", "ApprovalDate", "Approver", "EndDate", "IsPaidLeave", "LeaveCategory", "LeaveType", "Reason", "RequestedBy", "StartDate" },
                values: new object[] { "Approved", new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5777), "Daniel Moore", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Unpaid", "Unpaid", "Personal reasons", "Sophia Walker", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5864), new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5869), 4.5, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5876), 3.0, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5881), new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5882), 2.0, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5886), new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5888), 5.0, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5893), 6.0, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5899), new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5900), 4.0, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5905), 2.5, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5913), 3.5, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5917), new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5926), 5.0, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "Hours", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5950), new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5951), 4.5, new DateTime(2024, 8, 19, 23, 4, 19, 909, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 19, 23, 4, 19, 910, DateTimeKind.Local).AddTicks(9831));
        }
    }
}
