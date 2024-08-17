using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAndFeatures2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3342), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3350), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3358), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3364), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3370), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3376), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3382), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3388), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3451), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 8, 17, 8, 6, 57, 626, DateTimeKind.Utc).AddTicks(3457) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
