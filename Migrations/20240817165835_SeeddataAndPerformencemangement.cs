using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeeddataAndPerformencemangement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevelopmentPlans_Goals_GoalId",
                table: "DevelopmentPlans");

            migrationBuilder.DropIndex(
                name: "IX_DevelopmentPlans_GoalId",
                table: "DevelopmentPlans");

            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "DevelopmentPlans");

            migrationBuilder.AlterColumn<string>(
                name: "AttachmentUrl",
                table: "Overtimes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "Overtimes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Approver",
                table: "Leaves",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalComments",
                table: "Leaves",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "EducationJson",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkExperienceJson",
                table: "Applicants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "ApplicantId", "Address", "ApplicantName", "AppliedDate", "City", "Country", "EducationJson", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "PhoneNumber", "References", "ResumeUrl", "Skills", "Status", "WorkExperienceJson", "ZipCode" },
                values: new object[,]
                {
                    { 1, "123 Main St", "John Doe", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University A\",\"PassingYear\":\"2020\",\"Result\":3.5},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University B\",\"PassingYear\":\"2022\",\"Result\":3.8}]", "john.doe@example.com", 70000m, "English, Spanish", "https://linkedin.com/in/johndoe", "123-456-7890", "Available upon request", "https://example.com/resume/johndoe.pdf", "C#, .NET, SQL", "Approved", "[{\"Company\":\"Company X\",\"Position\":\"Software Engineer\",\"Duration\":\"2 years\"},{\"Company\":\"Company Y\",\"Position\":\"Senior Developer\",\"Duration\":\"3 years\"}]", "10001" },
                    { 2, "456 Elm St", "Jane Smith", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University C\",\"PassingYear\":\"2019\",\"Result\":3.7},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University D\",\"PassingYear\":\"2021\",\"Result\":3.9}]", "jane.smith@example.com", 80000m, "English, French", "https://linkedin.com/in/janesmith", "234-567-8901", "Available upon request", "https://example.com/resume/janesmith.pdf", "JavaScript, React, Node.js", "Pending", "[{\"Company\":\"Company A\",\"Position\":\"Front-End Developer\",\"Duration\":\"1 year\"},{\"Company\":\"Company B\",\"Position\":\"Full-Stack Developer\",\"Duration\":\"2 years\"}]", "90001" },
                    { 3, "789 Oak St", "Alice Johnson", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University E\",\"PassingYear\":\"2018\",\"Result\":3.6},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University F\",\"PassingYear\":\"2020\",\"Result\":3.8}]", "alice.johnson@example.com", 75000m, "English, German", "https://linkedin.com/in/alicejohnson", "345-678-9012", "Available upon request", "https://example.com/resume/alicejohnson.pdf", "Python, Django, PostgreSQL", "Rejected", "[{\"Company\":\"Company M\",\"Position\":\"Data Scientist\",\"Duration\":\"3 years\"},{\"Company\":\"Company N\",\"Position\":\"Machine Learning Engineer\",\"Duration\":\"2 years\"}]", "60601" },
                    { 4, "321 Pine St", "Bob Brown", new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University G\",\"PassingYear\":\"2017\",\"Result\":3.4},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University H\",\"PassingYear\":\"2019\",\"Result\":3.7}]", "bob.brown@example.com", 85000m, "English, Mandarin", "https://linkedin.com/in/bobbrown", "456-789-0123", "Available upon request", "https://example.com/resume/bobbrown.pdf", "C++, Unreal Engine", "Approved", "[{\"Company\":\"Company Q\",\"Position\":\"Game Developer\",\"Duration\":\"4 years\"},{\"Company\":\"Company R\",\"Position\":\"Lead Developer\",\"Duration\":\"1 year\"}]", "77001" },
                    { 5, "654 Maple St", "Eve White", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University I\",\"PassingYear\":\"2016\",\"Result\":3.5},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University J\",\"PassingYear\":\"2018\",\"Result\":3.6}]", "eve.white@example.com", 70000m, "English, Italian", "https://linkedin.com/in/evewhite", "567-890-1234", "Available upon request", "https://example.com/resume/evewhite.pdf", "PHP, Laravel", "Pending", "[{\"Company\":\"Company X\",\"Position\":\"Backend Developer\",\"Duration\":\"3 years\"},{\"Company\":\"Company Y\",\"Position\":\"Web Developer\",\"Duration\":\"2 years\"}]", "85001" },
                    { 6, "987 Birch St", "Mike Green", new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Philadelphia", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University K\",\"PassingYear\":\"2015\",\"Result\":3.4},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University L\",\"PassingYear\":\"2017\",\"Result\":3.6}]", "mike.green@example.com", 72000m, "English, Portuguese", "https://linkedin.com/in/mikegreen", "678-901-2345", "Available upon request", "https://example.com/resume/mikegreen.pdf", "Java, Spring Boot", "Rejected", "[{\"Company\":\"Company Z\",\"Position\":\"Java Developer\",\"Duration\":\"2 years\"},{\"Company\":\"Company W\",\"Position\":\"Senior Java Developer\",\"Duration\":\"3 years\"}]", "19101" },
                    { 7, "543 Cedar St", "Sophia Black", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Antonio", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University M\",\"PassingYear\":\"2014\",\"Result\":3.8},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University N\",\"PassingYear\":\"2016\",\"Result\":3.9}]", "sophia.black@example.com", 83000m, "English, Japanese", "https://linkedin.com/in/sophiablack", "789-012-3456", "Available upon request", "https://example.com/resume/sophiablack.pdf", "Swift, iOS Development", "Approved", "[{\"Company\":\"Company R\",\"Position\":\"iOS Developer\",\"Duration\":\"3 years\"},{\"Company\":\"Company S\",\"Position\":\"Lead iOS Developer\",\"Duration\":\"2 years\"}]", "78201" },
                    { 8, "876 Spruce St", "Liam Davis", new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Diego", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University O\",\"PassingYear\":\"2013\",\"Result\":3.5},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University P\",\"PassingYear\":\"2015\",\"Result\":3.7}]", "liam.davis@example.com", 76000m, "English, Korean", "https://linkedin.com/in/liamdavis", "890-123-4567", "Available upon request", "https://example.com/resume/liamdavis.pdf", "Go, Kubernetes", "Pending", "[{\"Company\":\"Company T\",\"Position\":\"Go Developer\",\"Duration\":\"2 years\"},{\"Company\":\"Company U\",\"Position\":\"Cloud Engineer\",\"Duration\":\"3 years\"}]", "92101" },
                    { 9, "543 Willow St", "Emma Wilson", new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University Q\",\"PassingYear\":\"2012\",\"Result\":3.6},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University R\",\"PassingYear\":\"2014\",\"Result\":3.7}]", "emma.wilson@example.com", 78000m, "English, Dutch", "https://linkedin.com/in/emmawilson", "901-234-5678", "Available upon request", "https://example.com/resume/emmawilson.pdf", "Ruby, Rails", "Approved", "[{\"Company\":\"Company V\",\"Position\":\"Ruby Developer\",\"Duration\":\"3 years\"},{\"Company\":\"Company W\",\"Position\":\"Senior Ruby Developer\",\"Duration\":\"2 years\"}]", "75201" },
                    { 10, "321 Fir St", "Oliver Martinez", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Jose", "USA", "[{\"Degree\":\"Bachelor\\u0027s Degree\",\"Institution\":\"University S\",\"PassingYear\":\"2011\",\"Result\":3.5},{\"Degree\":\"Master\\u0027s Degree\",\"Institution\":\"University T\",\"PassingYear\":\"2013\",\"Result\":3.6}]", "oliver.martinez@example.com", 71000m, "English, Russian", "https://linkedin.com/in/olivermartinez", "012-345-6789", "Available upon request", "https://example.com/resume/olivermartinez.pdf", "C#, ASP.NET Core", "Rejected", "[{\"Company\":\"Company D\",\"Position\":\"ASP.NET Developer\",\"Duration\":\"3 years\"},{\"Company\":\"Company E\",\"Position\":\"Senior ASP.NET Developer\",\"Duration\":\"1 year\"}]", "95101" }
                });

            migrationBuilder.InsertData(
                table: "DevelopmentPlans",
                columns: new[] { "DevelopmentPlanId", "CompletionDate", "Description", "DevelopmentPlanStatus", "EmployeeId", "Feedback", "IsActive", "Progress", "Resources", "TargetCompletionDate" },
                values: new object[,]
                {
                    { 1, null, "Improve communication skills.", 1, 1, "Needs more practice in public speaking.", true, 20, "Online communication course, public speaking workshops.", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, "Gain advanced skills in C#.", 0, 2, "Excellent progress so far.", true, 40, "Advanced C# course, mentorship.", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, "Enhance project management skills.", 1, 3, "Needs more focus on risk management.", true, 30, "PMI certification course, project simulations.", new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, "Improve time management.", 2, 4, "Plan rejected due to insufficient details.", false, 10, "Time management workshops, books.", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, "Develop leadership skills.", 1, 5, "Showing promise, continue with current plan.", true, 50, "Leadership seminars, mentoring.", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, "Learn new database management techniques.", 0, 6, "Great progress in database design.", true, 60, "SQL workshops, advanced database books.", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, "Master cloud computing.", 0, 7, "On track for certification.", true, 70, "Cloud certifications, online courses.", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, "Increase proficiency in Angular.", 0, 8, "Nearly complete, great work!", true, 80, "Angular documentation, online courses.", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, "Improve technical writing skills.", 1, 9, "Needs more practice.", true, 20, "Technical writing courses, guides.", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, "Gain proficiency in cybersecurity.", 0, 10, "Almost complete, keep up the good work!", true, 90, "Cybersecurity certifications, online courses.", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "GoalId", "AssignedByUserId", "Comments", "CompletionDate", "Description", "EmployeeId", "EndDate", "GoalStatus", "IsActive", "LastUpdatedDate", "Progress", "StartDate", "Title", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "On track for completion.", null, "Finish all tasks related to Project Alpha by Q3.", 1, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2797), 40, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete Project Alpha", "Manager" },
                    { 2, 2, "Sales are improving steadily.", null, "Boost sales by 20% by end of the year.", 2, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2802), 50, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Increase Sales by 20%", "Sales Director" },
                    { 3, 3, "Working on campaign materials.", null, "Introduce a new marketing campaign to increase brand awareness.", 3, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2805), 30, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Launch New Marketing Campaign", "Marketing Head" },
                    { 4, 4, "Plan needs more details.", null, "Improve customer support response time by 50%.", 4, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2807), 10, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enhance Customer Support", "Support Manager" },
                    { 5, 5, "Feature development is going well.", null, "Create and implement a new feature for the flagship product.", 5, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2809), 60, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop New Product Feature", "Product Manager" },
                    { 6, 6, "Identifying areas to reduce costs.", null, "Cut operational costs by 15% by Q4.", 6, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2811), 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reduce Operational Costs", "Operations Head" },
                    { 7, 7, "Collaboration tools have been introduced.", null, "Enhance collaboration across departments.", 7, new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2813), 50, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Improve Team Collaboration", "HR Manager" },
                    { 8, 8, "Supply chain optimization is in progress.", null, "Streamline the supply chain to reduce delays.", 8, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2815), 60, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optimize Supply Chain", "Supply Chain Manager" },
                    { 9, 9, "System is under testing.", null, "Introduce a new CRM system to improve customer management.", 9, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2817), 30, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Implement New CRM System", "IT Manager" },
                    { 10, 10, "Security protocols are being updated.", null, "Implement new data security measures to protect company assets.", 10, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2820), 70, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enhance Data Security", "Security Officer" }
                });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "JobPostingId", "ApplicationDeadline", "BenefitsOffered", "City", "ContactEmail", "ContactPhone", "Description", "EducationRequired", "ExperienceRequired", "IsActive", "IsInternal", "IsRemoteWork", "JobType", "PostingDate", "Requirements", "SalaryInformation", "SkillsRequired", "StartDate", "Title", "WorkSchedule" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, 401(k), Paid time off", "San Francisco", "hr@company.com", "123-456-7890", "Develop and maintain software applications.", "Bachelor's degree", "2 years", true, false, false, "Full-time", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bachelor's degree in Computer Science, 2+ years of experience.", "Competitive salary based on experience", "C#, .NET, SQL", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Engineer", "Monday to Friday, 9 AM to 5 PM" },
                    { 2, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, Flexible working hours", "New York", "design@company.com", "987-654-3210", "Design user-friendly interfaces and experiences.", "Associate's degree or higher", "3 years", true, true, true, "Part-time", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "3+ years of UX/UI design experience.", "Negotiable based on experience", "Sketch, Figma, Adobe XD", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UX Designer", "Flexible hours" },
                    { 3, new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, Retirement plan, Paid vacation", "Chicago", "pm@company.com", "555-123-4567", "Manage project timelines, budgets, and team coordination.", "Bachelor's degree", "5 years", true, false, false, "Full-time", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "PMP certification, 5+ years of project management experience.", "Up to $100,000 per year", "Project management, Budgeting, Scheduling", new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Project Manager", "Monday to Friday, 8 AM to 4 PM" },
                    { 4, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, Paid sick leave", "Los Angeles", "data@company.com", "321-654-9870", "Analyze data and generate reports to support business decisions.", "Bachelor's degree in a related field", "2 years", true, false, true, "Contract", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2+ years of data analysis experience, proficiency in SQL.", "Competitive salary, based on experience", "SQL, Excel, Data visualization", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Analyst", "Monday to Friday, 9 AM to 6 PM" },
                    { 5, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, 401(k), Paid time off", "Boston", "marketing@company.com", "654-321-0987", "Coordinate marketing campaigns and events.", "Bachelor's degree in Marketing or related field", "1 year", true, true, false, "Full-time", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "1+ years of marketing experience.", "Base salary + performance bonuses", "Marketing strategy, Event planning, Social media", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing Coordinator", "Monday to Friday, 8 AM to 5 PM" },
                    { 6, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, Paid time off", "Seattle", "support@company.com", "456-789-0123", "Provide customer support and resolve customer issues.", "High school diploma", "1 year", true, false, true, "Part-time", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excellent communication skills, 1+ years of customer service experience.", "Hourly rate + benefits", "Customer service, Problem-solving, Communication", new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Support Specialist", "Flexible hours" },
                    { 7, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, 401(k), Paid time off", "San Diego", "design@company.com", "789-012-3456", "Design marketing materials and brand assets.", "Bachelor's degree in Design or related field", "2 years", true, true, false, "Full-time", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2+ years of graphic design experience, portfolio required.", "Competitive salary based on experience", "Adobe Creative Suite, Graphic design, Creativity", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graphic Designer", "Monday to Friday, 9 AM to 5 PM" },
                    { 8, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, Paid time off", "Austin", "testing@company.com", "012-345-6789", "Test software applications to ensure quality and performance.", "Bachelor's degree in Computer Science", "1 year", true, false, true, "Contract", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "1+ years of software testing experience.", "Up to $80,000 per year", "Testing tools, Attention to detail, Problem-solving", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Tester", "Monday to Friday, 10 AM to 6 PM" },
                    { 9, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, 401(k), Paid vacation", "Philadelphia", "hr@company.com", "345-678-9012", "Manage HR functions and employee relations.", "Bachelor's degree in Human Resources or related field", "3 years", true, true, false, "Full-time", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "3+ years of HR experience, strong interpersonal skills.", "Negotiable based on experience", "HR management, Employee relations, Recruitment", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR Specialist", "Monday to Friday, 8 AM to 5 PM" },
                    { 10, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Healthcare, Flexible working hours", "Denver", "content@company.com", "456-789-1234", "Write and edit content for various platforms.", "Bachelor's degree in English or related field", "2 years", true, false, true, "Part-time", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "2+ years of content writing experience, strong writing skills.", "Competitive salary with performance bonuses", "Content writing, SEO, Editing", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Content Writer", "Flexible hours" }
                });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "LeaveId", "ApprovalComments", "ApprovalDate", "Approver", "EmployeeId", "EndDate", "IsActive", "IsPaidLeave", "LeaveCategory", "LeaveType", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, "Approved", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1318), "Jane Smith", 1, new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Annual", "Vacation", "Annual vacation", "John Doe", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 2, null, null, null, 2, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Medical", "Sick", "Medical reasons", "Alice Johnson", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 3, "Approved", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1335), "Michael Brown", 3, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Maternity", "Maternity", "Childbirth", "Emily Davis", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 4, "Approved", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1339), "Sarah Johnson", 4, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Personal", "Personal", "Personal matters", "David Wilson", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 5, "Approved", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1342), "Robert Brown", 5, new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Unpaid", "Unpaid", "Extended leave", "Jessica Lee", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 6, null, null, null, 6, new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Annual", "Vacation", "No coverage available", "Mark Taylor", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denied" },
                    { 7, "Approved", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1347), "Olivia White", 7, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Medical", "Sick", "Flu", "Anna Scott", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 8, null, null, null, 8, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Personal", "Personal", "Family event", "John Martin", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 9, "Approved", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1351), "James Miller", 9, new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Maternity", "Maternity", "Childbirth", "Laura Clark", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 10, "Approved", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1354), "Daniel Moore", 10, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Unpaid", "Unpaid", "Personal reasons", "Sophia Walker", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" }
                });

            migrationBuilder.InsertData(
                table: "Overtimes",
                columns: new[] { "OvertimeId", "ApprovalDate", "ApprovalStatus", "ApprovedBy", "AttachmentUrl", "CreatedBy", "CreatedDate", "Date", "Department", "EmployeeId", "Hours", "IsActive", "LastModifiedBy", "LastModifiedDate", "OvertimeType", "Project", "Reason" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1384), "Approved", "Jane Smith", "http://example.com/attachment1", "John Doe", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1386), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", 1, 4.5, true, "John Doe", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1387), "Voluntary", "Project A", "Project deadline" },
                    { 2, null, "Pending", null, null, "Alice Johnson", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", 2, 3.0, true, "Alice Johnson", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1392), "Mandatory", "System Upgrade", "System update" },
                    { 3, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1394), "Approved", "Michael Brown", "http://example.com/attachment2", "Emily Davis", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1395), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Support", 3, 2.0, true, "Emily Davis", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1395), "Voluntary", "Customer A", "Customer support" },
                    { 4, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1398), "Approved", "Sarah Johnson", "http://example.com/attachment3", "David Wilson", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", 4, 5.0, true, "David Wilson", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1399), "Mandatory", "Launch X", "Product launch" },
                    { 5, null, "Rejected", null, null, "Jessica Lee", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1405), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", 5, 6.0, true, "Jessica Lee", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1405), "Voluntary", "Training Session", "Training preparation" },
                    { 6, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1408), "Approved", "Robert Brown", "http://example.com/attachment4", "Mark Taylor", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1409), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", 6, 4.0, true, "Mark Taylor", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1410), "Voluntary", "Meeting Y", "Client meeting" },
                    { 7, null, "Pending", null, null, "Anna Scott", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1412), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Audit", 7, 2.5, true, "Anna Scott", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1412), "Mandatory", "Audit Z", "Audit preparation" },
                    { 8, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1415), "Approved", "Olivia White", "http://example.com/attachment5", "John Martin", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1416), new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", 8, 3.5, true, "John Martin", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1416), "Voluntary", "Task A", "Additional tasks" },
                    { 9, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1418), "Approved", "James Miller", "http://example.com/attachment6", "Laura Clark", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1419), new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emergency", 9, 5.0, true, "Laura Clark", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1420), "Mandatory", "Response X", "Emergency response" },
                    { 10, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1422), "Approved", "Daniel Moore", "http://example.com/attachment7", "Sophia Walker", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Service", 10, 4.5, true, "Sophia Walker", new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(1423), "Voluntary", "Support B", "Extra support" }
                });

            migrationBuilder.InsertData(
                table: "PayrollIntegrations",
                columns: new[] { "PayrollIntegrationId", "Amount", "Deductions", "EmployeeId", "GrossPay", "IntegrationDate", "IntegrationType", "IsActive", "NetPay", "PayFrequency", "PayPeriodEndDate", "PayPeriodStartDate", "PayrollSystemId", "TaxAmount", "TransactionId" },
                values: new object[,]
                {
                    { 1, 2500.00m, 150.00m, 1, 2550.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 2350.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 101, 200.00m, "TX12345" },
                    { 2, 3000.00m, 200.00m, 2, 3050.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 2800.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, 250.00m, "TX12346" },
                    { 3, 2700.00m, 180.00m, 3, 2740.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 2520.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, 220.00m, "TX12347" },
                    { 4, 2900.00m, 210.00m, 4, 2920.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 2690.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, 230.00m, "TX12348" },
                    { 5, 3200.00m, 230.00m, 5, 3240.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 2970.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 105, 270.00m, "TX12349" },
                    { 6, 3100.00m, 220.00m, 6, 3140.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 2880.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 106, 260.00m, "TX12350" },
                    { 7, 2800.00m, 190.00m, 7, 2850.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 2610.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 107, 240.00m, "TX12351" },
                    { 8, 3300.00m, 240.00m, 8, 3340.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 3060.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 108, 280.00m, "TX12352" },
                    { 9, 3500.00m, 250.00m, 9, 3550.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 3250.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 109, 290.00m, "TX12353" },
                    { 10, 3400.00m, 230.00m, 10, 3440.00m, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regular", true, 3170.00m, "Monthly", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 110, 270.00m, "TX12354" }
                });

            migrationBuilder.InsertData(
                table: "PerformanceReports",
                columns: new[] { "PerformanceReportId", "Achievements", "ActionItems", "AreasForImprovement", "Comments", "DevelopmentPlan", "EmployeeId", "EvaluationDate", "EvaluatorId", "GoalsMet", "OverallRating", "PerformanceScore", "ReviewPeriodEnd", "ReviewPeriodStart", "Status", "Strengths" },
                values: new object[,]
                {
                    { 1, "Led successful project delivery.", "Set up a follow-up meeting in 3 months.", "Needs to improve time management.", "Great performance, keep up the good work.", "Focus on time management training.", 1, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "5 out of 7", "Above Average", 85, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Excellent problem-solving skills." },
                    { 2, "Implemented new system architecture.", "Review progress in the next quarter.", "Needs better communication skills.", "Good overall performance, with room for improvement.", "Enroll in communication workshops.", 3, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "4 out of 6", "Average", 75, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Strong technical knowledge." },
                    { 3, "Successfully launched a new product line.", "Continue with leadership training.", "Focus on strategic planning.", "Outstanding performance, well done.", "Attend leadership and strategy seminars.", 5, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "6 out of 7", "Excellent", 90, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Excellent leadership and team management." },
                    { 4, "Analyzed and optimized business processes.", "Schedule a check-in meeting next quarter.", "Improve decision-making speed.", "Solid performance, needs slight improvements.", "Participate in decision-making workshops.", 7, new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "5 out of 7", "Above Average", 80, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Strong analytical skills." },
                    { 5, "Supported multiple successful projects.", "Review progress in the next performance cycle.", "Enhance technical skills.", "Needs improvement in technical aspects.", "Focus on technical certifications.", 9, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "3 out of 5", "Average", 70, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Good team collaboration." },
                    { 6, "Delivered complex project on time.", "Schedule a leadership training session.", "Needs to improve delegation skills.", "Good performance, with potential for growth.", "Attend workshops on delegation and leadership.", 2, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "4 out of 5", "Above Average", 85, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Great attention to detail." },
                    { 7, "Secured major client deals.", "Follow up on client feedback.", "Enhance negotiation skills.", "Solid performance with room for growth.", "Participate in negotiation training.", 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "5 out of 6", "Above Average", 80, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Strong client relationship management." },
                    { 8, "Contributed significantly to team success.", "Schedule a writing workshop.", "Improve technical documentation skills.", "Good performance, with minor improvements needed.", "Focus on technical writing courses.", 6, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "4 out of 5", "Average", 75, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Effective team player." },
                    { 9, "Contributed significantly to team success.", "Schedule a writing workshop.", "Improve technical documentation skills.", "Good performance, with minor improvements needed.", "Focus on technical writing courses.", 7, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "4 out of 5", "Average", 85, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Effective team player." },
                    { 10, "Contributed significantly to team success.", "Schedule a writing workshop.", "Improve technical documentation skills.", "Good performance, with minor improvements needed.", "Focus on technical writing courses.", 8, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "4 out of 5", "Average", 90, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", "Effective team player." }
                });

            migrationBuilder.InsertData(
                table: "PerformanceReviews",
                columns: new[] { "PerformanceReviewId", "Comments", "EmployeeId", "Feedback", "PerformanceRating", "ReviewDate", "ReviewType", "ReviewerId" },
                values: new object[,]
                {
                    { 1, "Exceptional performance", 1, "Great job overall, keep up the good work.", 5, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2910), "Annual", 1 },
                    { 2, "Solid performance", 2, "Good progress but needs improvement in communication.", 4, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2912), "Quarterly", 2 },
                    { 3, "Satisfactory performance", 3, "Requires more focus on client interactions.", 3, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2913), "Annual", 3 },
                    { 4, "Outstanding", 4, "Excellent leadership skills demonstrated.", 5, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2915), "Quarterly", 4 },
                    { 5, "Good effort", 5, "Good analytical skills, needs improvement in client relations.", 4, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2916), "Annual", 5 },
                    { 6, "Good teamwork", 6, "Strong teamwork but needs better project management.", 4, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2918), "Quarterly", 6 },
                    { 7, "Needs improvement", 7, "Creative thinking is a strength, work on organizational skills.", 3, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2919), "Annual", 7 },
                    { 8, "Very strong performance", 8, "Excellent technical expertise, communication skills need work.", 5, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2921), "Quarterly", 8 },
                    { 9, "Satisfactory", 9, "Dependable employee, needs improvement in time management.", 3, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2925), "Annual", 9 },
                    { 10, "Good performance", 10, "Great attention to detail, work on team collaboration.", 4, new DateTime(2024, 8, 17, 22, 58, 34, 550, DateTimeKind.Local).AddTicks(2927), "Quarterly", 10 }
                });

            migrationBuilder.InsertData(
                table: "Interviews",
                columns: new[] { "InterviewId", "ApplicantId", "DateTime", "DurationMinutes", "Feedback", "FollowUp", "InterviewType", "Interviewer", "IsActive", "Location", "Notes", "Outcome" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 30, "Candidate demonstrated strong technical skills.", "Schedule a technical interview.", 0, "John Smith", true, "Conference Room A", "Initial screening for software engineer position.", "Pending" },
                    { 2, 2, new DateTime(2024, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), 45, "Good problem-solving abilities, needs to improve on coding efficiency.", "Send coding challenge for further assessment.", 1, "Alice Johnson", true, "Zoom Meeting", "Technical interview with frontend developer.", "Pending" },
                    { 3, 3, new DateTime(2024, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), 60, "Excellent understanding of data analysis concepts.", "Prepare offer letter.", 2, "Robert Brown", true, "Office Lobby", "In-person interview for data scientist role.", "Hired" },
                    { 4, 4, new DateTime(2024, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), 40, "Strong leadership skills but lacks experience in Agile methodologies.", "Discuss with team regarding Agile experience.", 0, "Emily White", true, "Conference Room B", "Final round interview for project manager position.", "Pending" },
                    { 5, 5, new DateTime(2024, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 50, "Good design portfolio, needs improvement in user research.", "Arrange onboarding session.", 1, "Grace Clark", true, "Office Meeting Room", "Interview for UX designer position.", "Hired" },
                    { 6, 6, new DateTime(2024, 7, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 30, "Candidate has good analytical skills.", "Send rejection email.", 2, "Henry Allen", false, "Virtual Meeting", "Initial interview for business analyst role.", "Rejected" },
                    { 7, 7, new DateTime(2024, 7, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), 35, "Impressive technical knowledge but weak in communication skills.", "Consider additional communication training.", 0, "Linda Gray", true, "Conference Room C", "Technical interview for systems analyst position.", "Pending" },
                    { 8, 8, new DateTime(2024, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 60, "Strong technical background and problem-solving skills.", "Prepare employment contract.", 1, "Sarah Black", true, "Office Meeting Room", "Final interview for network engineer role.", "Hired" },
                    { 9, 9, new DateTime(2024, 7, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), 40, "Excellent knowledge of cloud technologies, needs to work on soft skills.", "Arrange for soft skills training.", 2, "Paul Black", true, "Zoom Meeting", "Interview for cloud engineer position.", "Pending" },
                    { 10, 10, new DateTime(2024, 7, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 30, "Good technical skills, but needs more experience in customer support.", "Send onboarding instructions.", 0, "Samantha Lee", true, "Office Conference Room", "Interview for IT support specialist.", "Hired" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DevelopmentPlans",
                keyColumn: "DevelopmentPlanId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Interviews",
                keyColumn: "InterviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "JobPostingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PayrollIntegrations",
                keyColumn: "PayrollIntegrationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PerformanceReports",
                keyColumn: "PerformanceReportId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Applicants",
                keyColumn: "ApplicantId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "EducationJson",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "WorkExperienceJson",
                table: "Applicants");

            migrationBuilder.AlterColumn<string>(
                name: "AttachmentUrl",
                table: "Overtimes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "Overtimes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Approver",
                table: "Leaves",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovalComments",
                table: "Leaves",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GoalId",
                table: "DevelopmentPlans",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentPlans_GoalId",
                table: "DevelopmentPlans",
                column: "GoalId");

            migrationBuilder.AddForeignKey(
                name: "FK_DevelopmentPlans_Goals_GoalId",
                table: "DevelopmentPlans",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "GoalId");
        }
    }
}
