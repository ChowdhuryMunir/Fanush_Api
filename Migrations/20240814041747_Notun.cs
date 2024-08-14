using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class Notun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5462), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5469), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5475), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5479), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5483), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5487), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5495), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5499), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5503), new DateTime(2024, 8, 14, 4, 17, 46, 66, DateTimeKind.Utc).AddTicks(5503) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5769), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5775), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5836), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5844), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5852), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5856), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5860) });
        }
    }
}
