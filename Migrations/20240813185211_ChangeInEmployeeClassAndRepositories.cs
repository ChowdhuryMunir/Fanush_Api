using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class ChangeInEmployeeClassAndRepositories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employees",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "EmergencyContact",
                table: "Employees",
                newName: "Religion");

            migrationBuilder.RenameColumn(
                name: "DateJoined",
                table: "Employees",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "Employees",
                newName: "ProfileImagePath");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitleName",
                table: "JobTitles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfJoining",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FathersName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MothersName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalId",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PresentAddress",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ActionType",
                table: "EmployeeLifecycles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "EmployeeDataImportExports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "EmployeeDataImportExports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "EmployeeDataImportExports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfBirth", "DateOfJoining", "Email", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "O+", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5769), new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "9876543210", "James Doe", "John", "Software Engineer", null, "Doe", "Married", "Anna Doe", "1234567890123", "American", "A12345678", "abc", "1234567890", "abc", "/images/profiles/john_doe.jpg", "Christian", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfBirth", "DateOfJoining", "Email", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "A+", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5775), new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "1234567890", "Robert Smith", "Jane", "Project Manager", null, "Smith", "Single", "Laura Smith", "9876543210987", "Canadian", "B23456789", "abc", "9876543210", "abc", "/images/profiles/jane_smith.jpg", "Christian", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfJoining", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "B+", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5832), new DateTime(2008, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6666666666", "David Johnson", "Michael", "HR Manager", null, "Johnson", "Married", "Emily Johnson", "5555555555555", "British", "C34567890", "abc", "5555555555", "abc", "/images/profiles/michael_johnson.jpg", "Christian", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfJoining", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "AB-", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5836), new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "3333333333", "William Brown", "Emily", "Business Analyst", null, "Brown", "Single", "Elizabeth Brown", "4444444444444", "Australian", "D45678901", "abc", "4444444444", "abc", "/images/profiles/emily_brown.jpg", "Christian", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfJoining", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "O-", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5840), new DateTime(2012, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "8888888888", "Thomas Wilson", "David", "Operations Manager", null, "Wilson", "Married", "Sophia Wilson", "7777777777777", "New Zealander", "E56789012", "abc", "7777777777", "abc", "/images/profiles/david_wilson.jpg", "Christian", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfJoining", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "A-", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5844), new DateTime(2016, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "9999999999", "Carlos Martinez", "Sophia", "Marketing Manager", null, "Martinez", "Single", "Maria Martinez", "2222222222222", "Spanish", "F67890123", "abc", "2222222222", "abc", "/images/profiles/sophia_martinez.jpg", "Catholic", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfJoining", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "B-", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5848), new DateTime(2005, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "1111111111", "Henry Taylor", "Daniel", "Finance Manager", null, "Taylor", "Married", "Alice Taylor", "6666666666666", "South African", "G78901234", "abc", "6666666666", "abc", "/images/profiles/daniel_taylor.jpg", "Jewish", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfJoining", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "AB+", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5852), new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "7777777777", "George Anderson", "Olivia", "Content Strategist", null, "Anderson", "Single", "Eleanor Anderson", "9999999999999", "American", "H89012345", "abc", "9999999999", "abc", "/images/profiles/olivia_anderson.jpg", "Christian", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfJoining", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "O+", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5856), new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "5555555555", "Samuel Thomas", "Ethan", "Data Scientist", null, "Thomas", "Married", "Lily Thomas", "3333333333333", "Indian", "I90123456", "abc", "3333333333", "abc", "/images/profiles/ethan_thomas.jpg", "Christian", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "BloodGroup", "CreatedBy", "CreatedOn", "DateOfJoining", "EmergencyContactNumber", "FathersName", "FirstName", "JobTitle", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "ProfileImagePath", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[] { "A+", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5860), new DateTime(2013, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "4444444444", "Frank White", "Ava", "UX Designer", null, "White", "Single", "Grace White", "8888888888888", "Canadian", "J01234567", "abc", "8888888888", "abc", "/images/profiles/ava_white.jpg", "Christian", "Admin", new DateTime(2024, 8, 13, 18, 52, 11, 25, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "JobTitleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DateOfJoining",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmergencyContactNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FathersName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MothersName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NationalId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PresentAddress",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Employees",
                newName: "DateJoined");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Employees",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "Religion",
                table: "Employees",
                newName: "EmergencyContact");

            migrationBuilder.RenameColumn(
                name: "ProfileImagePath",
                table: "Employees",
                newName: "ContactNumber");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitleName",
                table: "JobTitles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionType",
                table: "EmployeeLifecycles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "EmployeeDataImportExports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "EmployeeDataImportExports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "EmployeeDataImportExports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "ContactNumber", "DateJoined", "DateOfBirth", "Email", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "1234567890", new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshim@mail.com", "9876543210", "Joshim Bro", 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "ContactNumber", "DateJoined", "DateOfBirth", "Email", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "9876543210", new DateTime(2015, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sansa@example.com", "1234567890", "Sansa", 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "ContactNumber", "DateJoined", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "5555555555", new DateTime(2008, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6666666666", "Michael Johnson", 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "ContactNumber", "DateJoined", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "4444444444", new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "3333333333", "Emily Brown", 4 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "ContactNumber", "DateJoined", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "7777777777", new DateTime(2012, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "8888888888", "David Wilson", 5 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "ContactNumber", "DateJoined", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "2222222222", new DateTime(2016, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "9999999999", "Sophia Martinez", 6 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "ContactNumber", "DateJoined", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "6666666666", new DateTime(2005, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "1111111111", "Daniel Taylor", 7 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "ContactNumber", "DateJoined", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "9999999999", new DateTime(2020, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "7777777777", "Olivia Anderson", 8 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "ContactNumber", "DateJoined", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "3333333333", new DateTime(2018, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "5555555555", "Ethan Thomas", 9 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "ContactNumber", "DateJoined", "EmergencyContact", "EmployeeName", "JobTitleId" },
                values: new object[] { "8888888888", new DateTime(2013, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "4444444444", "Ava White", 10 });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "JobTitleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
