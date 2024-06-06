using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDataImportExports",
                columns: table => new
                {
                    ImportExportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportExportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDataImportExports", x => x.ImportExportId);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.JobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    JobTitleId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLifecycles",
                columns: table => new
                {
                    LifecycleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLifecycles", x => x.LifecycleId);
                    table.ForeignKey(
                        name: "FK_EmployeeLifecycles_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Engineering", true },
                    { 2, "Human Resources", true },
                    { 3, "Marketing", true },
                    { 4, "Finance", true },
                    { 5, "Operations", true },
                    { 6, "IT", true },
                    { 7, "Sales", true },
                    { 8, "Customer Service", true },
                    { 9, "Research & Development", true },
                    { 10, "Legal", true }
                });

            migrationBuilder.InsertData(
                table: "EmployeeDataImportExports",
                columns: new[] { "ImportExportId", "FileName", "FilePath", "ImportExportDate", "IsActive", "Type" },
                values: new object[,]
                {
                    { 1, "employees.xlsx", "/uploads/employees.xlsx", new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 2, "employees_export.xlsx", "/exports/employees_export.xlsx", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" },
                    { 3, "employees_backup.xlsx", "/backups/employees_backup.xlsx", new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 4, "employees_archive.xlsx", "/archives/employees_archive.xlsx", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" },
                    { 5, "employees_data.xlsx", "/uploads/employees_data.xlsx", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 6, "employees_info.xlsx", "/exports/employees_info.xlsx", new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" },
                    { 7, "employees_sheet.xlsx", "/uploads/employees_sheet.xlsx", new DateTime(2022, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 8, "employees_export_info.xlsx", "/exports/employees_export_info.xlsx", new DateTime(2022, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" },
                    { 9, "employees_data_sheet.xlsx", "/uploads/employees_data_sheet.xlsx", new DateTime(2022, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 10, "employees_info_backup.xlsx", "/exports/employees_info_backup.xlsx", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "JobTitleId", "IsActive", "JobTitleName" },
                values: new object[,]
                {
                    { 1, true, "Software Engineer" },
                    { 2, true, "HR Manager" },
                    { 3, true, "Quality Assurance Analyst" },
                    { 4, true, "Marketing Specialist" },
                    { 5, true, "Finance Manager" },
                    { 6, true, "Operations Coordinator" },
                    { 7, true, "IT Support Specialist" },
                    { 8, true, "Sales Representative" },
                    { 9, true, "Customer Service Representative" },
                    { 10, true, "Project Manager" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "ContactNumber", "DateJoined", "DateOfBirth", "DepartmentId", "Email", "EmergencyContact", "EmployeeName", "Gender", "IsActive", "JobTitleId" },
                values: new object[,]
                {
                    { 1, "1234567890", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Joshim@mail.com", "9876543210", "Joshim Bro", "Male", true, 1 },
                    { 2, "9876543210", new DateTime(2015, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sansa@example.com", "1234567890", "Sansa", "Female", true, 2 },
                    { 3, "5555555555", new DateTime(2008, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "michael.johnson@example.com", "6666666666", "Michael Johnson", "Male", true, 3 },
                    { 4, "4444444444", new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "emily.brown@example.com", "3333333333", "Emily Brown", "Female", true, 4 },
                    { 5, "7777777777", new DateTime(2012, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "david.wilson@example.com", "8888888888", "David Wilson", "Male", true, 5 },
                    { 6, "2222222222", new DateTime(2016, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "sophia.martinez@example.com", "9999999999", "Sophia Martinez", "Female", true, 6 },
                    { 7, "6666666666", new DateTime(2005, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "daniel.taylor@example.com", "1111111111", "Daniel Taylor", "Male", true, 7 },
                    { 8, "9999999999", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "olivia.anderson@example.com", "7777777777", "Olivia Anderson", "Female", true, 8 },
                    { 9, "3333333333", new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "ethan.thomas@example.com", "5555555555", "Ethan Thomas", "Male", true, 9 },
                    { 10, "8888888888", new DateTime(2013, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "ava.white@example.com", "4444444444", "Ava White", "Female", true, 10 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeLifecycles",
                columns: new[] { "LifecycleId", "ActionDate", "ActionType", "EmployeeId", "IsActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 1, true },
                    { 2, new DateTime(2015, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 2, true },
                    { 3, new DateTime(2008, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 3, true },
                    { 4, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 4, true },
                    { 5, new DateTime(2012, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 5, true },
                    { 6, new DateTime(2016, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 6, true },
                    { 7, new DateTime(2005, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 7, true },
                    { 8, new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 8, true },
                    { 9, new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 9, true },
                    { 10, new DateTime(2013, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onboarding", 10, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLifecycles_EmployeeId",
                table: "EmployeeLifecycles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobTitleId",
                table: "Employees",
                column: "JobTitleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDataImportExports");

            migrationBuilder.DropTable(
                name: "EmployeeLifecycles");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "JobTitles");
        }
    }
}
