using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInJobTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3148), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3155), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3161), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3175), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3180), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3186), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3191), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3195), new DateTime(2024, 8, 15, 4, 0, 43, 56, DateTimeKind.Utc).AddTicks(3196) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(547), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(571), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(577), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(581), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(629), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(634), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(638), new DateTime(2024, 8, 14, 15, 53, 17, 985, DateTimeKind.Utc).AddTicks(639) });
        }
    }
}
