using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4524), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4536), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4563), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4572), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4581), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4591), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4614), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4623), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4633), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4642), new DateTime(2024, 8, 17, 20, 25, 27, 524, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5192), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5194), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5202), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5213), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5220), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5230), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5233), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5238), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5291), new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 25, 27, 524, DateTimeKind.Local).AddTicks(6290));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1125), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1134), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1142), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1159), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1246), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1606), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1608), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1628), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1634), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1638), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1638), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1642), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1642), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2296));
        }
    }
}
