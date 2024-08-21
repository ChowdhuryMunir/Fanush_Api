using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9459), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9465), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9471), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9473) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9478), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9484), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9489), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9495), new DateTime(2024, 8, 21, 5, 42, 5, 770, DateTimeKind.Utc).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9887), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9900), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9904), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9908), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9911), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9911), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9912) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9915), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9922), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9928), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9929), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9932), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9932), new DateTime(2024, 8, 21, 11, 42, 5, 770, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 21, 11, 42, 5, 771, DateTimeKind.Local).AddTicks(5003));
        }
    }
}
