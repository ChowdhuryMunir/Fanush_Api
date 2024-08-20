using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAndFewChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3289), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3297), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3305), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3310), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3316), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3322), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3328), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3334), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3371), new DateTime(2024, 8, 20, 14, 45, 9, 955, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3733), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3736), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3737), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3740), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3741), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3747), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3748), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3751), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3754), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3755), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3757), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3758), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3762), new DateTime(2024, 8, 20, 20, 45, 9, 955, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.InsertData(
                table: "PayrollCalculations",
                columns: new[] { "PayrollCalcuationId", "BasicSalary", "ConveyanceAllowence", "EmployeeId", "HouseRent", "MedicalAllowence", "OtherAllowence" },
                values: new object[,]
                {
                    { 1, 50000m, 3000m, 1, 10000m, 5000m, 2000m },
                    { 2, 45000m, 2500m, 2, 9000m, 4500m, 1500m },
                    { 3, 47000m, 2700m, 3, 9400m, 4700m, 1700m },
                    { 4, 55000m, 3500m, 4, 11000m, 5500m, 2500m },
                    { 5, 48000m, 2800m, 5, 9600m, 4800m, 1800m },
                    { 6, 51000m, 3100m, 6, 10200m, 5100m, 2100m },
                    { 7, 49000m, 2900m, 7, 9800m, 4900m, 1900m },
                    { 8, 53000m, 3300m, 8, 10600m, 5300m, 2300m },
                    { 9, 56000m, 3600m, 9, 11200m, 5600m, 2600m },
                    { 10, 46000m, 2600m, 10, 9200m, 4600m, 1600m }
                });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 20, 20, 45, 9, 956, DateTimeKind.Local).AddTicks(1722));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PayrollCalculations",
                keyColumn: "PayrollCalcuationId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5649), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5657), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5664), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5672), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5679), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5685), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5691), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5712), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5767), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5778), new DateTime(2024, 8, 20, 11, 10, 2, 604, DateTimeKind.Utc).AddTicks(5779) });

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
    }
}
