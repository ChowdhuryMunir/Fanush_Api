using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class Changes1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9554), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9558), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9562), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9570), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9571), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9574), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9578), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9581), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9585), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9588), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9589), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9592), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9592), new DateTime(2024, 8, 20, 10, 12, 4, 51, DateTimeKind.Local).AddTicks(9593) });

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
        }
    }
}
