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
                name: "Applicants",
                columns: table => new
                {
                    ApplicantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResumeUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppliedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkedinProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    References = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.ApplicantId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportExportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDataImportExports", x => x.ImportExportId);
                });

            migrationBuilder.CreateTable(
                name: "JobPostings",
                columns: table => new
                {
                    JobPostingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsInternal = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationDeadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaryInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceRequired = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationRequired = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillsRequired = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BenefitsOffered = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkSchedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRemoteWork = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostings", x => x.JobPostingId);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.JobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantId = table.Column<int>(type: "int", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Institution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassingYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Educations_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    InterviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Interviewer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantId = table.Column<int>(type: "int", nullable: false),
                    InterviewType = table.Column<int>(type: "int", nullable: false),
                    DurationMinutes = table.Column<int>(type: "int", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowUp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.InterviewId);
                    table.ForeignKey(
                        name: "FK_Interviews_Applicants_ApplicantId",
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
                    ApplicantId = table.Column<int>(type: "int", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.WorkExperienceId);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "ApplicantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfJoining = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitleId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    EmergencyContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MothersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "AbsenceReports",
                columns: table => new
                {
                    AbsenceReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsHalfDay = table.Column<bool>(type: "bit", nullable: false),
                    HalfDayType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaysAbsent = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbsenceReports", x => x.AbsenceReportId);
                    table.ForeignKey(
                        name: "FK_AbsenceReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClockInOuts",
                columns: table => new
                {
                    ClockInOutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClockInTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClockOutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLateArrival = table.Column<bool>(type: "bit", nullable: false),
                    IsEarlyDeparture = table.Column<bool>(type: "bit", nullable: false),
                    IsWorkday = table.Column<bool>(type: "bit", nullable: false),
                    OvertimeHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsOvertime = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LateArrivalReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EarlyDepartureReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockInOuts", x => x.ClockInOutId);
                    table.ForeignKey(
                        name: "FK_ClockInOuts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DevelopmentPlans",
                columns: table => new
                {
                    DevelopmentPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DevelopmentPlanStatus = table.Column<int>(type: "int", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopmentPlans", x => x.DevelopmentPlanId);
                    table.ForeignKey(
                        name: "FK_DevelopmentPlans_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLifecycles",
                columns: table => new
                {
                    LifecycleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    GoalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    GoalStatus = table.Column<int>(type: "int", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignedByUserId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.GoalId);
                    table.ForeignKey(
                        name: "FK_Goals_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    LeaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Approver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsPaidLeave = table.Column<bool>(type: "bit", nullable: false),
                    LeaveCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.LeaveId);
                    table.ForeignKey(
                        name: "FK_Leaves_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Overtimes",
                columns: table => new
                {
                    OvertimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OvertimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachmentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Overtimes", x => x.OvertimeId);
                    table.ForeignKey(
                        name: "FK_Overtimes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayrollCalculations",
                columns: table => new
                {
                    PayrollCalcuationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicalAllowence = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConveyanceAllowence = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherAllowence = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollCalculations", x => x.PayrollCalcuationId);
                    table.ForeignKey(
                        name: "FK_PayrollCalculations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayrollIntegrations",
                columns: table => new
                {
                    PayrollIntegrationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PayrollSystemId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IntegrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntegrationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    PayPeriodStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayPeriodEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayFrequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deductions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollIntegrations", x => x.PayrollIntegrationId);
                    table.ForeignKey(
                        name: "FK_PayrollIntegrations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceReports",
                columns: table => new
                {
                    PerformanceReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EvaluatorId = table.Column<int>(type: "int", nullable: false),
                    EvaluationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerformanceScore = table.Column<int>(type: "int", nullable: true),
                    GoalsMet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Strengths = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreasForImprovement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achievements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevelopmentPlan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverallRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewPeriodStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionItems = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceReports", x => x.PerformanceReportId);
                    table.ForeignKey(
                        name: "FK_PerformanceReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerformanceReviews",
                columns: table => new
                {
                    PerformanceReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerformanceRating = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformanceReviews", x => x.PerformanceReviewId);
                    table.ForeignKey(
                        name: "FK_PerformanceReviews_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "ApplicantId", "Address", "ApplicantName", "AppliedDate", "City", "Country", "Email", "ExpectedSalary", "Languages", "LinkedinProfileUrl", "PhoneNumber", "References", "ResumeUrl", "Skills", "Status", "ZipCode" },
                values: new object[,]
                {
                    { 1, "123 Main St", "John Doe", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", "USA", "john.doe@example.com", 70000m, "English, Spanish", "https://linkedin.com/in/johndoe", "123-456-7890", "Available upon request", "https://example.com/resume/johndoe.pdf", "C#, .NET, SQL", "Approved", "10001" },
                    { 2, "456 Oak St", "Alice Johnson", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Francisco", "USA", "alice.johnson@example.com", 80000m, "English, Mandarin", "https://linkedin.com/in/alicejohnson", "234-567-8901", "Available upon request", "https://example.com/resume/alicejohnson.pdf", "JavaScript, React, Node.js", "Pending", "94101" },
                    { 3, "789 Pine St", "Robert Smith", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles", "USA", "robert.smith@example.com", 90000m, "English, French", "https://linkedin.com/in/robertsmith", "345-678-9012", "Available upon request", "https://example.com/resume/robertsmith.pdf", "Python, Django, Flask", "Approved", "90001" },
                    { 4, "101 Maple St", "Emily Davis", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", "USA", "emily.davis@example.com", 85000m, "English, German", "https://linkedin.com/in/emilydavis", "456-789-0123", "Available upon request", "https://example.com/resume/emilydavis.pdf", "Java, Spring, Hibernate", "Rejected", "60601" },
                    { 5, "202 Cedar St", "Michael Brown", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Houston", "USA", "michael.brown@example.com", 75000m, "English, Japanese", "https://linkedin.com/in/michaelbrown", "567-890-1234", "Available upon request", "https://example.com/resume/michaelbrown.pdf", "C++, Unreal Engine, Game Development", "Pending", "77001" },
                    { 6, "303 Spruce St", "Sophia Martinez", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phoenix", "USA", "sophia.martinez@example.com", 78000m, "English, Italian", "https://linkedin.com/in/sophiamartinez", "678-901-2345", "Available upon request", "https://example.com/resume/sophiamartinez.pdf", "Ruby on Rails, PostgreSQL, DevOps", "Approved", "85001" },
                    { 7, "404 Birch St", "David Lee", new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miami", "USA", "david.lee@example.com", 82000m, "English, Korean", "https://linkedin.com/in/davidlee", "789-012-3456", "Available upon request", "https://example.com/resume/davidlee.pdf", "Go, Kubernetes, Microservices", "Rejected", "33101" },
                    { 8, "505 Ash St", "Olivia Wilson", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle", "USA", "olivia.wilson@example.com", 77000m, "English, Spanish", "https://linkedin.com/in/oliviawilson", "890-123-4567", "Available upon request", "https://example.com/resume/oliviawilson.pdf", "Swift, iOS Development, UI/UX Design", "Pending", "98101" },
                    { 9, "606 Poplar St", "William Taylor", new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boston", "USA", "william.taylor@example.com", 90000m, "English, Portuguese", "https://linkedin.com/in/williamtaylor", "901-234-5678", "Available upon request", "https://example.com/resume/williamtaylor.pdf", "JavaScript, Angular, Node.js", "Approved", "02101" },
                    { 10, "707 Willow St", "Charlotte Harris", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas", "USA", "charlotte.harris@example.com", 84000m, "English, Russian", "https://linkedin.com/in/charlotteharris", "012-345-6789", "Available upon request", "https://example.com/resume/charlotteharris.pdf", "PHP, Laravel, MySQL", "Pending", "75201" }
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
                columns: new[] { "ImportExportId", "DataPath", "ImportExportDate", "IsActive", "Type" },
                values: new object[,]
                {
                    { 1, "/data/imports/employee_data_2023.csv", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 2, "/data/exports/employee_data_2023.xlsx", new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" },
                    { 3, "/data/imports/employee_data_2023_part2.csv", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 4, "/data/exports/employee_data_backup_2023.csv", new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" },
                    { 5, "/data/imports/employee_data_new_records.csv", new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 6, "/data/exports/employee_data_summary_2023.xlsx", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" },
                    { 7, "/data/imports/employee_attendance_data_2023.csv", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 8, "/data/exports/employee_performance_data_2023.xlsx", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" },
                    { 9, "/data/imports/employee_salary_data_2023.csv", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Import" },
                    { 10, "/data/exports/employee_data_full_2023.xlsx", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Export" }
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
                table: "Educations",
                columns: new[] { "EducationId", "ApplicantId", "Degree", "Institution", "PassingYear", "Result" },
                values: new object[,]
                {
                    { 1, 1, "Bachelor's Degree", "University A", "2020", 3.5m },
                    { 2, 2, "Master's Degree", "University B", "2022", 3.8m },
                    { 3, 3, "PhD", "University C", "2024", 4.0m },
                    { 4, 4, "Associate's Degree", "College D", "2018", 3.2m },
                    { 5, 5, "Diploma", "Institute E", "2019", 3.0m },
                    { 6, 6, "Bachelor's Degree", "University F", "2021", 3.6m },
                    { 7, 7, "Master's Degree", "University G", "2023", 3.9m },
                    { 8, 8, "Certificate", "Training Center H", "2022", 3.8m },
                    { 9, 9, "High School", "School I", "2017", 3.1m },
                    { 10, 10, "Bachelor's Degree", "University J", "2020", 3.7m }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BloodGroup", "CreatedBy", "CreatedOn", "DateOfBirth", "DateOfJoining", "DepartmentId", "Email", "EmergencyContactNumber", "FathersName", "FirstName", "Gender", "ImagePath", "IsActive", "JobTitleId", "LastName", "MaritalStatus", "MothersName", "NationalId", "Nationality", "PassportNumber", "PermanentAddress", "PhoneNumber", "PresentAddress", "Religion", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "O+", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9451), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "amit.roy@example.com", "01823456789", "Shankar Roy", "Amit", "Male", "/images/amitroy.jpg", true, 1, "Roy", "Single", "Mina Roy", "123456789012", "Bangladeshi", "A1234567", "456 River Road, Chattogram", "01712345678", "123 Lake Road, Dhaka", "Hindu", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9453) },
                    { 2, "A+", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9462), new DateTime(1985, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "rina.chakraborty@example.com", "01834567890", "Kumar Chakraborty", "Rina", "Female", "/images/rinachakraborty.jpg", true, 2, "Chakraborty", "Married", "Soma Chakraborty", "234567890123", "Bangladeshi", "B2345678", "1012 Beach Road, Sylhet", "01787654321", "789 Hill Street, Dhaka", "Hindu", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9463) },
                    { 3, "B+", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9470), new DateTime(1988, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sanjay.ghosh@example.com", "01845678901", "Suresh Ghosh", "Sanjay", "Male", "/images/sanjayghosh.jpg", true, 3, "Ghosh", "Single", "Anita Ghosh", "345678901234", "Bangladeshi", "C3456789", "456 Blue Lane, Bogura", "01798765432", "123 Green Lane, Dhaka", "Hindu", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9470) },
                    { 4, "AB+", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9476), new DateTime(1992, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "mina.das@example.com", "01856789012", "Ramesh Das", "Mina", "Female", "/images/minadas.jpg", true, 4, "Das", "Divorced", "Gita Das", "456789012345", "Bangladeshi", "D4567890", "654 Park Avenue, Khulna", "01745678901", "321 Market Street, Dhaka", "Hindu", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9476) },
                    { 5, "O-", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9556), new DateTime(1987, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "arif.hossain@example.com", "01867890123", "Mohammad Hossain", "Arif", "Male", "/images/arifhossain.jpg", true, 5, "Hossain", "Married", "Fatema Hossain", "567890123456", "Bangladeshi", "E5678901", "1012 Central Road, Rajshahi", "01712349876", "789 Hill Top, Dhaka", "Muslim", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9556) },
                    { 6, "AB-", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9563), new DateTime(1995, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "jaya.mukherjee@example.com", "01878901234", "Dipak Mukherjee", "Jaya", "Female", "/images/jayamukherjee.jpg", true, 6, "Mukherjee", "Single", "Kakoli Mukherjee", "678901234567", "Bangladeshi", "F6789012", "789 Maple Avenue, Moulvibazar", "01734567890", "456 Oak Street, Dhaka", "Hindu", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9563) },
                    { 7, "B-", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9569), new DateTime(1989, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "rafig.khan@example.com", "01889012345", "Aziz Khan", "Rafiq", "Male", "/images/rafiqukhan.jpg", true, 7, "Khan", "Widowed", "Amina Khan", "789012345678", "Bangladeshi", "G7890123", "202 Cedar Road, Barishal", "01765432109", "101 Pine Lane, Dhaka", "Muslim", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9570) },
                    { 8, "A-", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9576), new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "sonali.saha@example.com", "01890123456", "Babul Saha", "Sonali", "Female", "/images/sonalisaha.jpg", true, 8, "Saha", "Married", "Rina Saha", "890123456789", "Bangladeshi", "H8901234", "345 Pine Avenue, Sylhet", "01723456789", "234 Maple Street, Dhaka", "Hindu", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9576) },
                    { 9, "O+", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9582), new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "imran.ahmed@example.com", "01891234567", "Mohammad Ahmed", "Imran", "Male", "/images/imranahmed.jpg", true, 9, "Ahmed", "Single", "Nasima Ahmed", "901234567890", "Bangladeshi", "I9012345", "678 Elm Street, Rangpur", "01756789012", "567 Birch Lane, Dhaka", "Muslim", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9582) },
                    { 10, "AB+", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9588), new DateTime(1993, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "anita.bhattacharya@example.com", "01893456789", "Pranab Bhattacharya", "Anita", "Female", "/images/anitabhattacharya.jpg", true, 10, "Bhattacharya", "Married", "Chitra Bhattacharya", "012345678901", "Bangladeshi", "J0123456", "123 Oak Road, Comilla", "01767890123", "890 Walnut Street, Dhaka", "Hindu", "admin", new DateTime(2024, 8, 22, 4, 44, 28, 536, DateTimeKind.Utc).AddTicks(9588) }
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

            migrationBuilder.InsertData(
                table: "WorkExperiences",
                columns: new[] { "WorkExperienceId", "ApplicantId", "Company", "Duration", "Position" },
                values: new object[,]
                {
                    { 1, 1, "TechCorp", "2 years", "Software Engineer" },
                    { 2, 2, "WebSolutions", "3 years", "Frontend Developer" },
                    { 3, 3, "DataWorks", "4 years", "Data Scientist" },
                    { 4, 4, "FinanceTech", "1 year", "Backend Developer" },
                    { 5, 5, "GameStudio", "2 years", "Game Developer" },
                    { 6, 6, "DevOpsInc", "3 years", "DevOps Engineer" },
                    { 7, 7, "MicroServicesCo", "4 years", "Microservices Architect" },
                    { 8, 8, "AppDesign", "2 years", "iOS Developer" },
                    { 9, 9, "WebTech", "3 years", "Full Stack Developer" },
                    { 10, 10, "EnterpriseSolutions", "5 years", "PHP Developer" }
                });

            migrationBuilder.InsertData(
                table: "AbsenceReports",
                columns: new[] { "AbsenceReportId", "ApprovedDate", "Approver", "DaysAbsent", "EmployeeId", "EndDate", "HalfDayType", "IsHalfDay", "IsPaid", "Reason", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 3, 10, 30, 0, 0, DateTimeKind.Unspecified), "John Doe", 2.0m, 1, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, true, "Medical Leave", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 2, new DateTime(2024, 7, 14, 9, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 0.5m, 2, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning", true, false, "Personal Leave", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 3, new DateTime(2024, 8, 6, 14, 15, 0, 0, DateTimeKind.Unspecified), "John Doe", 3.0m, 3, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, false, "Family Emergency", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 4, new DateTime(2024, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 2.0m, 4, new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, true, "Sick Leave", new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 5, new DateTime(2024, 8, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 0.5m, 5, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afternoon", true, false, "Doctor's Appointment", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 6, new DateTime(2024, 7, 29, 9, 30, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 2.0m, 6, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, true, "Vacation", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 7, new DateTime(2024, 8, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 2.0m, 7, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, true, "Jury Duty", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 8, new DateTime(2024, 8, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 0.5m, 8, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning", true, false, "Bereavement Leave", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 9, new DateTime(2024, 7, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), "John Doe", 2.0m, 9, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, false, "Travel", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 10, new DateTime(2024, 8, 9, 10, 45, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 2.0m, 10, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "None", false, true, "Training", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" }
                });

            migrationBuilder.InsertData(
                table: "ClockInOuts",
                columns: new[] { "ClockInOutId", "Action", "ApprovedBy", "ClockInTime", "ClockOutTime", "EarlyDepartureReason", "EmployeeId", "IsActive", "IsEarlyDeparture", "IsLateArrival", "IsOvertime", "IsWorkday", "LateArrivalReason", "Location", "Notes", "OvertimeHours", "Timestamp" },
                values: new object[,]
                {
                    { 1, "ClockIn", "John Doe", new DateTime(2024, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 1, true, false, false, false, true, "", "Office A", "Normal day", 0m, new DateTime(2024, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "ClockIn", "Jane Smith", new DateTime(2024, 8, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), null, 2, true, false, true, true, true, "Traffic", "Office B", "Late arrival due to traffic", 0.5m, new DateTime(2024, 8, 2, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "ClockIn", "Emily Johnson", new DateTime(2024, 8, 3, 7, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 16, 45, 0, 0, DateTimeKind.Unspecified), null, 3, true, false, false, false, true, "", "Remote", "Working from home", 0m, new DateTime(2024, 8, 3, 7, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "ClockIn", "Michael Brown", new DateTime(2024, 8, 4, 8, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 17, 15, 0, 0, DateTimeKind.Unspecified), null, 4, true, false, true, true, true, "Doctor's appointment", "Office C", "Late due to doctor's appointment", 0.25m, new DateTime(2024, 8, 4, 8, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "ClockIn", "David Wilson", new DateTime(2024, 8, 5, 7, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 17, 5, 0, 0, DateTimeKind.Unspecified), null, 5, true, false, false, true, true, "", "Office A", "Arrived early", 0.17m, new DateTime(2024, 8, 5, 7, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "ClockIn", "John Doe", new DateTime(2024, 8, 6, 8, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 16, 5, 0, 0, DateTimeKind.Unspecified), null, 6, true, false, true, false, true, "Family emergency", "Remote", "Late due to family emergency", 0m, new DateTime(2024, 8, 6, 8, 5, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "ClockIn", "Jane Smith", new DateTime(2024, 8, 7, 8, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 17, 10, 0, 0, DateTimeKind.Unspecified), null, 7, true, false, true, true, true, "Transport issues", "Office B", "Slight delay due to transport issues", 0.17m, new DateTime(2024, 8, 7, 8, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "ClockIn", "Emily Johnson", new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 8, true, false, false, false, true, "", "Office C", "Normal clock-in", 0m, new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "ClockIn", "Michael Brown", new DateTime(2024, 8, 9, 7, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 16, 50, 0, 0, DateTimeKind.Unspecified), null, 9, true, false, false, true, true, "", "Remote", "Early clock-in", 0.17m, new DateTime(2024, 8, 9, 7, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "ClockIn", "David Wilson", new DateTime(2024, 8, 10, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 17, 20, 0, 0, DateTimeKind.Unspecified), null, 10, true, false, true, true, true, "Personal reasons", "Office A", "Late due to personal reasons", 0.17m, new DateTime(2024, 8, 10, 8, 20, 0, 0, DateTimeKind.Unspecified) }
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

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "GoalId", "AssignedByUserId", "Comments", "CompletionDate", "Description", "EmployeeId", "EndDate", "GoalStatus", "IsActive", "LastUpdatedDate", "Progress", "StartDate", "Title", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "On track for completion.", null, "Finish all tasks related to Project Alpha by Q3.", 1, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(3979), 40, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete Project Alpha", "Manager" },
                    { 2, 2, "Sales are improving steadily.", null, "Boost sales by 20% by end of the year.", 2, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(3986), 50, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Increase Sales by 20%", "Sales Director" },
                    { 3, 3, "Working on campaign materials.", null, "Introduce a new marketing campaign to increase brand awareness.", 3, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(3989), 30, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Launch New Marketing Campaign", "Marketing Head" },
                    { 4, 4, "Plan needs more details.", null, "Improve customer support response time by 50%.", 4, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(3992), 10, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enhance Customer Support", "Support Manager" },
                    { 5, 5, "Feature development is going well.", null, "Create and implement a new feature for the flagship product.", 5, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(3994), 60, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop New Product Feature", "Product Manager" },
                    { 6, 6, "Identifying areas to reduce costs.", null, "Cut operational costs by 15% by Q4.", 6, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(3997), 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reduce Operational Costs", "Operations Head" },
                    { 7, 7, "Collaboration tools have been introduced.", null, "Enhance collaboration across departments.", 7, new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(3999), 50, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Improve Team Collaboration", "HR Manager" },
                    { 8, 8, "Supply chain optimization is in progress.", null, "Streamline the supply chain to reduce delays.", 8, new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4003), 60, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optimize Supply Chain", "Supply Chain Manager" },
                    { 9, 9, "System is under testing.", null, "Introduce a new CRM system to improve customer management.", 9, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4005), 30, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Implement New CRM System", "IT Manager" },
                    { 10, 10, "Security protocols are being updated.", null, "Implement new data security measures to protect company assets.", 10, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, true, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4008), 70, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enhance Data Security", "Security Officer" }
                });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "LeaveId", "ApprovalComments", "ApprovalDate", "Approver", "EmployeeId", "EndDate", "IsActive", "IsPaidLeave", "LeaveCategory", "LeaveType", "NumberOfDays", "Reason", "RequestedBy", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, "Take care", new DateTime(2024, 7, 31, 10, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 1, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Sick Leave", "Sick Leave", 3.0m, "Fever and cold", "John Doe", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 2, "Enjoy your time", new DateTime(2024, 7, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), "John Doe", 2, new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Vacation Leave", "Vacation", 6.0m, "Family vacation", "Jane Smith", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 3, "Pending approval", new DateTime(2024, 8, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 3, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, "Maternity Leave", "Maternity Leave", 9.0m, "Maternity", "Emily Clark", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 4, "Condolences", new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 4, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Bereavement Leave", "Bereavement Leave", 6.0m, "Loss of family member", "Michael Brown", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 5, "Get well soon", new DateTime(2024, 7, 24, 10, 15, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 5, new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Sick Leave", "Sick Leave", 2.0m, "Migraine", "Sarah Johnson", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 6, "Safe travels", new DateTime(2024, 8, 15, 11, 30, 0, 0, DateTimeKind.Unspecified), "John Doe", 6, new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Vacation Leave", "Vacation", 6.0m, "Holiday trip", "David Williams", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 7, "Take rest", new DateTime(2024, 7, 29, 14, 45, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 7, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Sick Leave", "Sick Leave", 2.0m, "Back pain", "James White", new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 8, "Congrats!", new DateTime(2024, 9, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 8, new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Paternity Leave", "Paternity Leave", 15.0m, "Newborn care", "Robert Green", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 9, "Take care", new DateTime(2024, 8, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), "Jane Smith", 9, new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Sick Leave", "Sick Leave", 3.0m, "Flu", "William Black", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" },
                    { 10, "Enjoy your time off", new DateTime(2024, 8, 20, 12, 15, 0, 0, DateTimeKind.Unspecified), "John Doe", 10, new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, "Vacation Leave", "Vacation", 6.0m, "Beach holiday", "Jessica King", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved" }
                });

            migrationBuilder.InsertData(
                table: "Overtimes",
                columns: new[] { "OvertimeId", "ApprovalDate", "ApprovalStatus", "ApprovedBy", "AttachmentUrl", "CreatedBy", "CreatedDate", "Date", "Department", "EmployeeId", "Hours", "IsActive", "LastModifiedBy", "LastModifiedDate", "OvertimeType", "Project", "Reason" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9962), "Approved", "Jane Smith", "http://example.com/attachment1", "John Doe", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", 1, 4.5m, true, "John Doe", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9977), "Voluntary", "Project A", "Project deadline" },
                    { 2, null, "Pending", null, null, "Alice Johnson", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9981), new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", 2, 3.0m, true, "Alice Johnson", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9981), "Mandatory", "System Upgrade", "System update" },
                    { 3, new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9984), "Approved", "Michael Brown", "http://example.com/attachment2", "Emily Davis", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9985), new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Support", 3, 2.0m, true, "Emily Davis", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9985), "Voluntary", "Customer A", "Customer support" },
                    { 4, new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9988), "Approved", "Sarah Johnson", "http://example.com/attachment3", "David Wilson", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", 4, 5.0m, true, "David Wilson", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9990), "Mandatory", "Launch X", "Product launch" },
                    { 5, null, "Rejected", null, null, "Jessica Lee", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9992), new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "HR", 5, 6.0m, true, "Jessica Lee", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9993), "Voluntary", "Training Session", "Training preparation" },
                    { 6, new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9995), "Approved", "Robert Brown", "http://example.com/attachment4", "Mark Taylor", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", 6, 4.0m, true, "Mark Taylor", new DateTime(2024, 8, 22, 10, 44, 28, 536, DateTimeKind.Local).AddTicks(9997), "Voluntary", "Meeting Y", "Client meeting" },
                    { 7, null, "Pending", null, null, "Anna Scott", new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local), new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Audit", 7, 2.5m, true, "Anna Scott", new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(1), "Mandatory", "Audit Z", "Audit preparation" },
                    { 8, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(3), "Approved", "Olivia White", "http://example.com/attachment5", "John Martin", new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4), new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", 8, 3.5m, true, "John Martin", new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(5), "Voluntary", "Task A", "Additional tasks" },
                    { 9, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(7), "Approved", "James Miller", "http://example.com/attachment6", "Laura Clark", new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(8), new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emergency", 9, 5.0m, true, "Laura Clark", new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(9), "Mandatory", "Response X", "Emergency response" },
                    { 10, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(11), "Approved", "Daniel Moore", "http://example.com/attachment7", "Sophia Walker", new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(12), new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Service", 10, 4.5m, true, "Sophia Walker", new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(13), "Voluntary", "Support B", "Extra support" }
                });

            migrationBuilder.InsertData(
                table: "PayrollCalculations",
                columns: new[] { "PayrollCalcuationId", "BasicSalary", "ConveyanceAllowence", "EmployeeId", "HouseRent", "MedicalAllowence", "OtherAllowence" },
                values: new object[,]
                {
                    { 1, 50000m, 3000m, 1, 10000m, 5000m, 2000m },
                    { 2, 45000m, 2500m, 2, 9000m, 4500m, 1500m },
                    { 3, 47000m, 2700m, 3, 9400m, 4700m, 1700m },
                    { 4, 55000m, 3500m, 4, 11000m, 5500m, 2500m },
                    { 5, 48000m, 2800m, 5, 9600m, 4800m, 1800m },
                    { 6, 51000m, 3100m, 6, 10200m, 5100m, 2100m },
                    { 7, 49000m, 2900m, 7, 9800m, 4900m, 1900m },
                    { 8, 53000m, 3300m, 8, 10600m, 5300m, 2300m },
                    { 9, 56000m, 3600m, 9, 11200m, 5600m, 2600m },
                    { 10, 46000m, 2600m, 10, 9200m, 4600m, 1600m }
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
                    { 1, "Exceptional performance", 1, "Great job overall, keep up the good work.", 5, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4108), "Annual", 1 },
                    { 2, "Solid performance", 2, "Good progress but needs improvement in communication.", 4, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4110), "Quarterly", 2 },
                    { 3, "Satisfactory performance", 3, "Requires more focus on client interactions.", 3, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4112), "Annual", 3 },
                    { 4, "Outstanding", 4, "Excellent leadership skills demonstrated.", 5, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4114), "Quarterly", 4 },
                    { 5, "Good effort", 5, "Good analytical skills, needs improvement in client relations.", 4, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4115), "Annual", 5 },
                    { 6, "Good teamwork", 6, "Strong teamwork but needs better project management.", 4, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4118), "Quarterly", 6 },
                    { 7, "Needs improvement", 7, "Creative thinking is a strength, work on organizational skills.", 3, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4119), "Annual", 7 },
                    { 8, "Very strong performance", 8, "Excellent technical expertise, communication skills need work.", 5, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4121), "Quarterly", 8 },
                    { 9, "Satisfactory", 9, "Dependable employee, needs improvement in time management.", 3, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4123), "Annual", 9 },
                    { 10, "Good performance", 10, "Great attention to detail, work on team collaboration.", 4, new DateTime(2024, 8, 22, 10, 44, 28, 537, DateTimeKind.Local).AddTicks(4125), "Quarterly", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbsenceReports_EmployeeId",
                table: "AbsenceReports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClockInOuts_EmployeeId",
                table: "ClockInOuts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentPlans_EmployeeId",
                table: "DevelopmentPlans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ApplicantId",
                table: "Educations",
                column: "ApplicantId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Goals_EmployeeId",
                table: "Goals",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_ApplicantId",
                table: "Interviews",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_EmployeeId",
                table: "Leaves",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Overtimes_EmployeeId",
                table: "Overtimes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayrollCalculations_EmployeeId",
                table: "PayrollCalculations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PayrollIntegrations_EmployeeId",
                table: "PayrollIntegrations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReports_EmployeeId",
                table: "PerformanceReports",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PerformanceReviews_EmployeeId",
                table: "PerformanceReviews",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_ApplicantId",
                table: "WorkExperiences",
                column: "ApplicantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbsenceReports");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClockInOuts");

            migrationBuilder.DropTable(
                name: "DevelopmentPlans");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EmployeeDataImportExports");

            migrationBuilder.DropTable(
                name: "EmployeeLifecycles");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropTable(
                name: "JobPostings");

            migrationBuilder.DropTable(
                name: "Leaves");

            migrationBuilder.DropTable(
                name: "Overtimes");

            migrationBuilder.DropTable(
                name: "PayrollCalculations");

            migrationBuilder.DropTable(
                name: "PayrollIntegrations");

            migrationBuilder.DropTable(
                name: "PerformanceReports");

            migrationBuilder.DropTable(
                name: "PerformanceReviews");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "JobTitles");
        }
    }
}
