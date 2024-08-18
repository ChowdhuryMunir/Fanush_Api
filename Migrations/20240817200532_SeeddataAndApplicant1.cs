using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeeddataAndApplicant1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 1,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 1, "Bachelor's Degree in Computer Science" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 2,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 2, "Master's Degree in Information Technology" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 3,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 3, "PhD in Data Science" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 4,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 4, "Associate's Degree in Web Development" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 5,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 5, "Diploma in Graphic Design" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 6,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 6, "Bachelor's Degree in Business Administration" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 7,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 7, "Master's Degree in Marketing" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 8,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 8, "Certificate in Project Management" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 9,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 9, "High School Diploma" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 10,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 10, "Bachelor's Degree in Psychology" });

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
                columns: new[] { "ApplicantId", "Company" },
                values: new object[] { 1, "Tech Solutions Inc." });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 2,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 2, "Creative Minds Ltd.", "1.5 years", "Graphic Designer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 3,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 3, "Global Innovations", "3 years", "Project Manager" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 4,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 4, "Web Solutions LLC", "2.5 years", "Front-End Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 5,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 5, "Marketing Pros", "2 years", "Digital Marketing Specialist" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 6,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 6, "IT Services Ltd.", "3.5 years", "System Analyst" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 7,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 7, "Corporate Solutions Inc.", "4 years", "HR Manager" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 8,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 8, "Startup X", "1 year", "Product Manager" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 9,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 9, "Finance Corp.", "3 years", "Accountant" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 10,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 10, "Healthcare Solutions", "2.5 years", "Healthcare Consultant" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 1,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "Bachelor's Degree" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 2,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "Master's Degree" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 3,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "PhD" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 4,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "Associate's Degree" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 5,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "Diploma" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 6,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "Bachelor's Degree" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 7,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "Master's Degree" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 8,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "Certificate" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 9,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "High School" });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "EducationId",
                keyValue: 10,
                columns: new[] { "ApplicantId", "Degree" },
                values: new object[] { 0, "Bachelor's Degree" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6007), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6022), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6029), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6034), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6041), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6047), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6052), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6057), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6063), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6068), new DateTime(2024, 8, 17, 19, 57, 39, 867, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6378), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6384), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6387), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6387), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6390), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6391), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6393), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6396), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6397), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6399), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6403), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6403), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6407), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6409), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6410), new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 1, 57, 39, 867, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 1,
                columns: new[] { "ApplicantId", "Company" },
                values: new object[] { 0, "Company X" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 2,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 0, "Company Y", "3 years", "Senior Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 3,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 0, "Company Z", "5 years", "Lead Developer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 4,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 0, "Company A", "6 months", "Intern" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 5,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 0, "Company B", "4 years", "Project Manager" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 6,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 0, "Company C", "1 year", "QA Engineer" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 7,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 0, "Company D", "2 years", "HR Specialist" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 8,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 0, "Company E", "3 years", "Data Analyst" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 9,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 0, "Company F", "2 years", "Consultant" });

            migrationBuilder.UpdateData(
                table: "WorkExperiences",
                keyColumn: "WorkExperienceId",
                keyValue: 10,
                columns: new[] { "ApplicantId", "Company", "Duration", "Position" },
                values: new object[] { 0, "Company G", "4 years", "Tech Lead" });
        }
    }
}
