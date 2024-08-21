using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9587), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9588) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9595), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9602), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9608), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9615), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9620), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9626), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9646), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9652), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9658), new DateTime(2024, 8, 21, 6, 41, 50, 888, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(68), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(81), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(87), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(91), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(107), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(111), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(115), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(119), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(120), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(161), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(164), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(165), new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 41, 50, 889, DateTimeKind.Local).AddTicks(7332));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8019), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8028), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8095), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8102), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8109), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8115), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8123), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8129), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8135), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8140), new DateTime(2024, 8, 21, 6, 26, 33, 533, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8495), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8511), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8514), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8518), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8518), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8521), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8524), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8525), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8530), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8533), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8533), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8537), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8539), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8540), new DateTime(2024, 8, 21, 12, 26, 33, 533, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 12, 26, 33, 534, DateTimeKind.Local).AddTicks(2766));
        }
    }
}
