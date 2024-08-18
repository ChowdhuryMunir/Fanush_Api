using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanush.Migrations
{
    /// <inheritdoc />
    public partial class SeeddataAndApplicant5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Applicants_ApplicantId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Applicants_ApplicantId",
                table: "WorkExperiences");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1132), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1140), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1148), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1154), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1161), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1170), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1175), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1182), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 8, 17, 20, 38, 55, 618, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2588), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2592), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2602), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2606), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2607), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2618), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2618), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2623), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2630), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2631), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2636), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2640), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2641), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2646), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2647), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2651), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2652), new DateTime(2024, 8, 18, 2, 38, 55, 618, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 38, 55, 619, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Applicants_ApplicantId",
                table: "Educations",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "ApplicantId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Applicants_ApplicantId",
                table: "WorkExperiences",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "ApplicantId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Applicants_ApplicantId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Applicants_ApplicantId",
                table: "WorkExperiences");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5768), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5776), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5782), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5787), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5801), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5806), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5812), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5817), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5822), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5827), new DateTime(2024, 8, 17, 20, 32, 52, 940, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 1,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 2,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 3,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 4,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 5,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 6,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 7,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 8,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 9,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Goals",
                keyColumn: "GoalId",
                keyValue: 10,
                column: "LastUpdatedDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 1,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 3,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 4,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 5,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 7,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 9,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Leaves",
                keyColumn: "LeaveId",
                keyValue: 10,
                column: "ApprovalDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 1,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6129), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6132), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6137), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 3,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6140), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6141), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 4,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6143), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6144), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6147), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 6,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6152), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6153), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6156), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 8,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6158), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6159), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 9,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6161), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6162), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Overtimes",
                keyColumn: "OvertimeId",
                keyValue: 10,
                columns: new[] { "ApprovalDate", "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6165), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6165), new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 4,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 6,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 7,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 8,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 9,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "PerformanceReviews",
                keyColumn: "PerformanceReviewId",
                keyValue: 10,
                column: "ReviewDate",
                value: new DateTime(2024, 8, 18, 2, 32, 52, 940, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Applicants_ApplicantId",
                table: "Educations",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "ApplicantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Applicants_ApplicantId",
                table: "WorkExperiences",
                column: "ApplicantId",
                principalTable: "Applicants",
                principalColumn: "ApplicantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
