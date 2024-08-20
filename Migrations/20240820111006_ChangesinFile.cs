using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class ChangesinFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5649), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5657), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5664), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5672), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5679), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5685), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5691), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5712), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5767), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ImagePath", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5778), null, new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6219), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6236), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6242), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6257), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6260), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6263), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6264), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6286), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 8, 20, 17, 10, 2, 604, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 17, 10, 2, 605, DateTimeKind.Local).AddTicks(2796));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Employees");

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
    }
}
