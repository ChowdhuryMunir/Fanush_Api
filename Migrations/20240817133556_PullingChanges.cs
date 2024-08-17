using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class PullingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevelopmentPlans_Goals_GoalId",
                table: "DevelopmentPlans");

            migrationBuilder.AlterColumn<int>(
                name: "GoalId",
                table: "DevelopmentPlans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(904), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(912), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(919), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(924), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(930), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(936), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(942), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 8, 17, 13, 35, 55, 446, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.AddForeignKey(
                name: "FK_DevelopmentPlans_Goals_GoalId",
                table: "DevelopmentPlans",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "GoalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevelopmentPlans_Goals_GoalId",
                table: "DevelopmentPlans");

            migrationBuilder.AlterColumn<int>(
                name: "GoalId",
                table: "DevelopmentPlans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6503), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6589), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6596), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6602), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6609), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6615), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6621), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6626), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6633), new DateTime(2024, 8, 17, 8, 21, 54, 451, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.AddForeignKey(
                name: "FK_DevelopmentPlans_Goals_GoalId",
                table: "DevelopmentPlans",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "GoalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
