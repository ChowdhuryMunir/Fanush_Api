using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class Changes3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeductedAmount",
                table: "PayrollCalculations");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(303), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(311), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(318), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(323), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(330), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(336), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(341), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(363), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(369), new DateTime(2024, 8, 20, 5, 29, 5, 170, DateTimeKind.Utc).AddTicks(369) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(798), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(802), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(806), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(816), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(820), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(824), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(827), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(831), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(834), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(835), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(838), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(839), new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 11, 29, 5, 170, DateTimeKind.Local).AddTicks(7251));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DeductedAmount",
                table: "PayrollCalculations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6590), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6599), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6606), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6612), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6618), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6625), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6666), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6687), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6693), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6699), new DateTime(2024, 8, 20, 4, 33, 13, 933, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7196), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7200), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7207), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7214), new DateTime(2024, 8, 20, 10, 33, 13, 933, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 10, 33, 13, 934, DateTimeKind.Local).AddTicks(3227));
        }
    }
}
