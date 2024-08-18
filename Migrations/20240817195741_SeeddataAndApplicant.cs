using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeeddataAndApplicant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationJson",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Education_Degree",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Education_Institution",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Education_PassingYear",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Education_Result",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "WorkExperienceJson",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "WorkExperience_Company",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "WorkExperience_Duration",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "WorkExperience_Position",
                table: "Applicants");

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Institution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApplicantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Educations_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    WorkExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.WorkExperienceId);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 2,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "Email", "Languages", "LinkedinProfileUrl", "ResumeUrl", "ZipCode" },
                values: new object[] { "456 Oak St", "Alice Johnson", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Francisco", "alice.johnson@example.com", "English, Mandarin", "https://linkedin.com/in/alicejohnson", "https://example.com/resume/alicejohnson.pdf", "94101" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 3,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "ZipCode" },
                values: new object[] { "789 Pine St", "Robert Smith", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles", "robert.smith@example.com", 90000m, "English, French", "https://linkedin.com/in/robertsmith", "https://example.com/resume/robertsmith.pdf", "Python, Django, Flask", "Approved", "90001" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 4,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "Email", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "ZipCode" },
                values: new object[] { "101 Maple St", "Emily Davis", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", "emily.davis@example.com", "English, German", "https://linkedin.com/in/emilydavis", "https://example.com/resume/emilydavis.pdf", "Java, Spring, Hibernate", "Rejected", "60601" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 5,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "ZipCode" },
                values: new object[] { "202 Cedar St", "Michael Brown", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "michael.brown@example.com", 75000m, "English, Japanese", "https://linkedin.com/in/michaelbrown", "https://example.com/resume/michaelbrown.pdf", "C++, Unreal Engine, Game Development", "77001" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 6,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "ZipCode" },
                values: new object[] { "303 Spruce St", "Sophia Martinez", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix", "sophia.martinez@example.com", 78000m, "English, Italian", "https://linkedin.com/in/sophiamartinez", "https://example.com/resume/sophiamartinez.pdf", "Ruby on Rails, PostgreSQL, DevOps", "Approved", "85001" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 7,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "ZipCode" },
                values: new object[] { "404 Birch St", "David Lee", new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miami", "david.lee@example.com", 82000m, "English, Korean", "https://linkedin.com/in/davidlee", "https://example.com/resume/davidlee.pdf", "Go, Kubernetes, Microservices", "Rejected", "33101" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 8,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "ZipCode" },
                values: new object[] { "505 Ash St", "Olivia Wilson", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle", "olivia.wilson@example.com", 77000m, "English, Spanish", "https://linkedin.com/in/oliviawilson", "https://example.com/resume/oliviawilson.pdf", "Swift, iOS Development, UI/UX Design", "98101" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 9,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "ZipCode" },
                values: new object[] { "606 Poplar St", "William Taylor", new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boston", "william.taylor@example.com", 90000m, "English, Portuguese", "https://linkedin.com/in/williamtaylor", "https://example.com/resume/williamtaylor.pdf", "JavaScript, Angular, Node.js", "02101" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 10,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "Email", "ExpectedSalary", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "ZipCode" },
                values: new object[] { "707 Willow St", "Charlotte Harris", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", "charlotte.harris@example.com", 84000m, "https://linkedin.com/in/charlotteharris", "https://example.com/resume/charlotteharris.pdf", "PHP, Laravel, MySQL", "Pending", "75201" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EducationId", "ApplicantId", "Degree", "Institution", "PassingYear", "Result" },
                values: new object[,]
                {
                    { 1, 0, "Bachelor's Degree", "University A", "2020", 3.5m },
                    { 2, 0, "Master's Degree", "University B", "2022", 3.8m },
                    { 3, 0, "PhD", "University C", "2024", 4.0m },
                    { 4, 0, "Associate's Degree", "College D", "2018", 3.2m },
                    { 5, 0, "Diploma", "Institute E", "2019", 3.0m },
                    { 6, 0, "Bachelor's Degree", "University F", "2021", 3.6m },
                    { 7, 0, "Master's Degree", "University G", "2023", 3.9m },
                    { 8, 0, "Certificate", "Training Center H", "2022", 3.8m },
                    { 9, 0, "High School", "School I", "2017", 3.1m },
                    { 10, 0, "Bachelor's Degree", "University J", "2020", 3.7m }
                });

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

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "WorkExperienceId", "ApplicantId", "Company", "Duration", "Position" },
                values: new object[,]
                {
                    { 1, 0, "Company X", "2 years", "Software Developer" },
                    { 2, 0, "Company Y", "3 years", "Senior Developer" },
                    { 3, 0, "Company Z", "5 years", "Lead Developer" },
                    { 4, 0, "Company A", "6 months", "Intern" },
                    { 5, 0, "Company B", "4 years", "Project Manager" },
                    { 6, 0, "Company C", "1 year", "QA Engineer" },
                    { 7, 0, "Company D", "2 years", "HR Specialist" },
                    { 8, 0, "Company E", "3 years", "Data Analyst" },
                    { 9, 0, "Company F", "2 years", "Consultant" },
                    { 10, 0, "Company G", "4 years", "Tech Lead" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ApplicantId",
                table: "Educations",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_ApplicantId",
                table: "WorkExperiences",
                column: "ApplicantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.AddColumn<string>(
                name: "EducationJson",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Education_Degree",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Education_Institution",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Education_PassingYear",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Education_Result",
                table: "Applicants",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "WorkExperienceJson",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkExperience_Company",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkExperience_Duration",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkExperience_Position",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 1,
                columns: new[] { "EducationJson", "WorkExperienceJson" },
                values: new object[] { "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University A\",\"PassingYear\":\"2020\",\"Result\":3.5},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University B\",\"PassingYear\":\"2022\",\"Result\":3.8}]", "[{\"Company\":\"Company X\",\"Position\":\"Software Engineer\",\"Duration\":\"2 years\"},{\"Company\":\"Company Y\",\"Position\":\"Senior Developer\",\"Duration\":\"3 years\"}]" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 2,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "EducationJson", "Email", "Languages", "LinkedinProfileUrl", "ResumeUrl", "WorkExperienceJson", "ZipCode" },
                values: new object[] { "456 Elm St", "Jane Smith", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University C\",\"PassingYear\":\"2019\",\"Result\":3.7},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University D\",\"PassingYear\":\"2021\",\"Result\":3.9}]", "jane.smith@example.com", "English, French", "https://linkedin.com/in/janesmith", "https://example.com/resume/janesmith.pdf", "[{\"Company\":\"Company A\",\"Position\":\"Front-End Developer\",\"Duration\":\"1 year\"},{\"Company\":\"Company B\",\"Position\":\"Full-Stack Developer\",\"Duration\":\"2 years\"}]", "90001" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 3,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "EducationJson", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "WorkExperienceJson", "ZipCode" },
                values: new object[] { "789 Oak St", "Alice Johnson", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University E\",\"PassingYear\":\"2018\",\"Result\":3.6},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University F\",\"PassingYear\":\"2020\",\"Result\":3.8}]", "alice.johnson@example.com", 75000m, "English, German", "https://linkedin.com/in/alicejohnson", "https://example.com/resume/alicejohnson.pdf", "Python, Django, PostgreSQL", "Rejected", "[{\"Company\":\"Company M\",\"Position\":\"Data Scientist\",\"Duration\":\"3 years\"},{\"Company\":\"Company N\",\"Position\":\"Machine Learning Engineer\",\"Duration\":\"2 years\"}]", "60601" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 4,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "EducationJson", "Email", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "WorkExperienceJson", "ZipCode" },
                values: new object[] { "321 Pine St", "Bob Brown", new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University G\",\"PassingYear\":\"2017\",\"Result\":3.4},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University H\",\"PassingYear\":\"2019\",\"Result\":3.7}]", "bob.brown@example.com", "English, Mandarin", "https://linkedin.com/in/bobbrown", "https://example.com/resume/bobbrown.pdf", "C++, Unreal Engine", "Approved", "[{\"Company\":\"Company Q\",\"Position\":\"Game Developer\",\"Duration\":\"4 years\"},{\"Company\":\"Company R\",\"Position\":\"Lead Developer\",\"Duration\":\"1 year\"}]", "77001" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 5,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "EducationJson", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "WorkExperienceJson", "ZipCode" },
                values: new object[] { "654 Maple St", "Eve White", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University I\",\"PassingYear\":\"2016\",\"Result\":3.5},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University J\",\"PassingYear\":\"2018\",\"Result\":3.6}]", "eve.white@example.com", 70000m, "English, Italian", "https://linkedin.com/in/evewhite", "https://example.com/resume/evewhite.pdf", "PHP, Laravel", "[{\"Company\":\"Company X\",\"Position\":\"Backend Developer\",\"Duration\":\"3 years\"},{\"Company\":\"Company Y\",\"Position\":\"Web Developer\",\"Duration\":\"2 years\"}]", "85001" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 6,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "EducationJson", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "WorkExperienceJson", "ZipCode" },
                values: new object[] { "987 Birch St", "Mike Green", new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philadelphia", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University K\",\"PassingYear\":\"2015\",\"Result\":3.4},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University L\",\"PassingYear\":\"2017\",\"Result\":3.6}]", "mike.green@example.com", 72000m, "English, Portuguese", "https://linkedin.com/in/mikegreen", "https://example.com/resume/mikegreen.pdf", "Java, Spring Boot", "Rejected", "[{\"Company\":\"Company Z\",\"Position\":\"Java Developer\",\"Duration\":\"2 years\"},{\"Company\":\"Company W\",\"Position\":\"Senior Java Developer\",\"Duration\":\"3 years\"}]", "19101" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 7,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "EducationJson", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "WorkExperienceJson", "ZipCode" },
                values: new object[] { "543 Cedar St", "Sophia Black", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Antonio", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University M\",\"PassingYear\":\"2014\",\"Result\":3.8},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University N\",\"PassingYear\":\"2016\",\"Result\":3.9}]", "sophia.black@example.com", 83000m, "English, Japanese", "https://linkedin.com/in/sophiablack", "https://example.com/resume/sophiablack.pdf", "Swift, iOS Development", "Approved", "[{\"Company\":\"Company R\",\"Position\":\"iOS Developer\",\"Duration\":\"3 years\"},{\"Company\":\"Company S\",\"Position\":\"Lead iOS Developer\",\"Duration\":\"2 years\"}]", "78201" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 8,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "EducationJson", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "WorkExperienceJson", "ZipCode" },
                values: new object[] { "876 Spruce St", "Liam Davis", new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Diego", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University O\",\"PassingYear\":\"2013\",\"Result\":3.5},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University P\",\"PassingYear\":\"2015\",\"Result\":3.7}]", "liam.davis@example.com", 76000m, "English, Korean", "https://linkedin.com/in/liamdavis", "https://example.com/resume/liamdavis.pdf", "Go, Kubernetes", "[{\"Company\":\"Company T\",\"Position\":\"Go Developer\",\"Duration\":\"2 years\"},{\"Company\":\"Company U\",\"Position\":\"Cloud Engineer\",\"Duration\":\"3 years\"}]", "92101" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 9,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "EducationJson", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "ResumeUrl", "Skills", "WorkExperienceJson", "ZipCode" },
                values: new object[] { "543 Willow St", "Emma Wilson", new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University Q\",\"PassingYear\":\"2012\",\"Result\":3.6},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University R\",\"PassingYear\":\"2014\",\"Result\":3.7}]", "emma.wilson@example.com", 78000m, "English, Dutch", "https://linkedin.com/in/emmawilson", "https://example.com/resume/emmawilson.pdf", "Ruby, Rails", "[{\"Company\":\"Company V\",\"Position\":\"Ruby Developer\",\"Duration\":\"3 years\"},{\"Company\":\"Company W\",\"Position\":\"Senior Ruby Developer\",\"Duration\":\"2 years\"}]", "75201" });

            migrationBuilder.UpdateData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 10,
                columns: new[] { "Address", "ApplicantName", "AppliedDate", "City", "EducationJson", "Email", "ExpectedSalary", "LinkedinProfileUrl", "ResumeUrl", "Skills", "Status", "WorkExperienceJson", "ZipCode" },
                values: new object[] { "321 Fir St", "Oliver Martinez", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Jose", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University S\",\"PassingYear\":\"2011\",\"Result\":3.5},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University T\",\"PassingYear\":\"2013\",\"Result\":3.6}]", "oliver.martinez@example.com", 71000m, "https://linkedin.com/in/olivermartinez", "https://example.com/resume/olivermartinez.pdf", "C#, ASP.NET Core", "Rejected", "[{\"Company\":\"Company D\",\"Position\":\"ASP.NET Developer\",\"Duration\":\"3 years\"},{\"Company\":\"Company E\",\"Position\":\"Senior ASP.NET Developer\",\"Duration\":\"1 year\"}]", "95101" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(999), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1015), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1020), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1034), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1039), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1048), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1049) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1054), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1060), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1066), new DateTime(2024, 8, 17, 16, 58, 34, 550, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1384), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1386), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1394), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1395), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1405), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1408), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1409), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1415), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1416), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1418), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1419), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2927));
        }
    }
}
