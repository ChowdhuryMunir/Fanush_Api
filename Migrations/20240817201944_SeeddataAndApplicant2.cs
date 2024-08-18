using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeeddataAndApplicant2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "WorkExperiences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "Educations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 1,
                column: "Degree",
                value: "Bachelor's Degree");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 2,
                column: "Degree",
                value: "Master's Degree");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 3,
                column: "Degree",
                value: "PhD");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 4,
                column: "Degree",
                value: "Associate's Degree");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 5,
                column: "Degree",
                value: "Diploma");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 6,
                column: "Degree",
                value: "Bachelor's Degree");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 7,
                column: "Degree",
                value: "Master's Degree");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 8,
                column: "Degree",
                value: "Certificate");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 9,
                column: "Degree",
                value: "High School");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 10,
                column: "Degree",
                value: "Bachelor's Degree");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1125), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1134), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1142), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1159), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1246), new DateTime(2024, 8, 17, 20, 19, 43, 167, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1606), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1608), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1628), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1634), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1638), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1638), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1642), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1642), new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 19, 43, 167, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 1,
                columns: new[] { "Company", "Position" },
                values: new object[] { "TechCorp", "Software Engineer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 2,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "WebSolutions", "3 years", "Frontend Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 3,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "DataWorks", "4 years", "Data Scientist" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 4,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "FinanceTech", "1 year", "Backend Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 5,
                columns: new[] { "Company", "Position" },
                values: new object[] { "GameStudio", "Game Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 6,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "DevOpsInc", "3 years", "DevOps Engineer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 7,
                columns: new[] { "Company", "Position" },
                values: new object[] { "MicroServicesCo", "Microservices Architect" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 8,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "AppDesign", "2 years", "iOS Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 9,
                columns: new[] { "Company", "Position" },
                values: new object[] { "WebTech", "Full Stack Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 10,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "EnterpriseSolutions", "5 years", "PHP Developer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "WorkExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicantId",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 1,
                column: "Degree",
                value: "Bachelor's Degree in Computer Science");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 2,
                column: "Degree",
                value: "Master's Degree in Information Technology");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 3,
                column: "Degree",
                value: "PhD in Data Science");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 4,
                column: "Degree",
                value: "Associate's Degree in Web Development");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 5,
                column: "Degree",
                value: "Diploma in Graphic Design");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 6,
                column: "Degree",
                value: "Bachelor's Degree in Business Administration");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 7,
                column: "Degree",
                value: "Master's Degree in Marketing");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 8,
                column: "Degree",
                value: "Certificate in Project Management");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 9,
                column: "Degree",
                value: "High School Diploma");

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 10,
                column: "Degree",
                value: "Bachelor's Degree in Psychology");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3867), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3876), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3883), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3888), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3894), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3900), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3906), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3912), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3949), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3954), new DateTime(2024, 8, 17, 20, 5, 31, 527, DateTimeKind.Utc).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4298), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4307), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4310), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4311), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4313), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4314), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4317), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4321), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4324), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4327), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4329), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4331), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4335), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4336), new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 5, 31, 527, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 1,
                columns: new[] { "Company", "Position" },
                values: new object[] { "Tech Solutions Inc.", "Software Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 2,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "Creative Minds Ltd.", "1.5 years", "Graphic Designer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 3,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "Global Innovations", "3 years", "Project Manager" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 4,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "Web Solutions LLC", "2.5 years", "Front-End Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 5,
                columns: new[] { "Company", "Position" },
                values: new object[] { "Marketing Pros", "Digital Marketing Specialist" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 6,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "IT Services Ltd.", "3.5 years", "System Analyst" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 7,
                columns: new[] { "Company", "Position" },
                values: new object[] { "Corporate Solutions Inc.", "HR Manager" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 8,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "Startup X", "1 year", "Product Manager" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 9,
                columns: new[] { "Company", "Position" },
                values: new object[] { "Finance Corp.", "Accountant" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 10,
                columns: new[] { "Company", "Duration", "Position" },
                values: new object[] { "Healthcare Solutions", "2.5 years", "Healthcare Consultant" });
        }
    }
}
