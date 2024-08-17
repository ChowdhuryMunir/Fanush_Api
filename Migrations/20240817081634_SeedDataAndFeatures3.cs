using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAndFeatures3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Goals",
                newName: "GoalStatus");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "DevelopmentPlans",
                newName: "DevelopmentPlanStatus");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3652), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3660), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3670), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3676), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3682), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3689), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3695), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3701), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3706), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3713), new DateTime(2024, 8, 17, 8, 16, 32, 570, DateTimeKind.Utc).AddTicks(3714) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GoalStatus",
                table: "Goals",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "DevelopmentPlanStatus",
                table: "DevelopmentPlans",
                newName: "Status");

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
    }
}
