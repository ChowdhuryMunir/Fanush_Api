using Fanush.Entities.PayrollManagement;
﻿using Fanush.Entities.Administrator;
using Fanush.Entities.PerformenceManagement;
using Fanush.Entities.RecruitmentManagement;
using Fanush.Entities.TimeAndAttendence;
using Fanush.Models.EmployeeManagement;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using static Fanush.Entities.RecruitmentManagement.Applicant;

namespace Fanush.DAL
{
    public class FanushDbContext : IdentityDbContext<AppUser>
    {
        public FanushDbContext(DbContextOptions<FanushDbContext> options) : base(options)
        { 
        
        }


        #region EmployeeManagement
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<EmployeeLifecycle> EmployeeLifecycles { get; set; }
        public DbSet<EmployeeDataImportExport> EmployeeDataImportExports { get; set; }
        #endregion EmployeeManagement

        #region RecruitManagement
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
        public DbSet<Applicant> Applicants { get; set; }

        public DbSet<Education> Educations { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        #endregion RecruitManagement

        #region TimeAndAttendence
        public DbSet<ClockInOut> ClockInOuts { get; set; }
        public DbSet<AbsenceReport> AbsenceReports { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Overtime> Overtimes { get; set; }
        public DbSet<PayrollIntegration> PayrollIntegrations { get; set; }
        #endregion TimeAndAttendence

        #region PerformenceManagement
        public DbSet<DevelopmentPlan> DevelopmentPlans { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<PerformanceReport> PerformanceReports { get; set; }
        public DbSet<PerformanceReview> PerformanceReviews { get; set; }
        #endregion PerformenceManagement

        public DbSet<PayrollCalculation> PayrollCalculations { get; set; }

        #region Seed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region SeedDataForEmpoyeeMangement
            // Seed data for JobTitles
            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle { JobTitleId = 1, JobTitleName = "Software Engineer", IsActive = true },
                new JobTitle { JobTitleId = 2, JobTitleName = "HR Manager", IsActive = true },
                new JobTitle { JobTitleId = 3, JobTitleName = "Quality Assurance Analyst", IsActive = true },
                new JobTitle { JobTitleId = 4, JobTitleName = "Marketing Specialist", IsActive = true },
                new JobTitle { JobTitleId = 5, JobTitleName = "Finance Manager", IsActive = true },
                new JobTitle { JobTitleId = 6, JobTitleName = "Operations Coordinator", IsActive = true },
                new JobTitle { JobTitleId = 7, JobTitleName = "IT Support Specialist", IsActive = true },
                new JobTitle { JobTitleId = 8, JobTitleName = "Sales Representative", IsActive = true },
                new JobTitle { JobTitleId = 9, JobTitleName = "Customer Service Representative", IsActive = true },
                new JobTitle { JobTitleId = 10, JobTitleName = "Project Manager", IsActive = true }
            );

            // Seed data for Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "Engineering", IsActive = true },
                new Department { DepartmentId = 2, DepartmentName = "Human Resources", IsActive = true },
                new Department { DepartmentId = 3, DepartmentName = "Marketing", IsActive = true },
                new Department { DepartmentId = 4, DepartmentName = "Finance", IsActive = true },
                new Department { DepartmentId = 5, DepartmentName = "Operations", IsActive = true },
                new Department { DepartmentId = 6, DepartmentName = "IT", IsActive = true },
                new Department { DepartmentId = 7, DepartmentName = "Sales", IsActive = true },
                new Department { DepartmentId = 8, DepartmentName = "Customer Service", IsActive = true },
                new Department { DepartmentId = 9, DepartmentName = "Research & Development", IsActive = true },
                new Department { DepartmentId = 10, DepartmentName = "Legal", IsActive = true }
            );

            // Seed data for Employees
            modelBuilder.Entity<Employee>().HasData(
           new Employee
           {
               EmployeeId = 1,
               FirstName = "Amit",
               LastName = "Roy",
               DateOfBirth = new DateTime(1990, 5, 15),
               Gender = "Male",
               PresentAddress = "123 Lake Road, Dhaka",
               PermanentAddress = "456 River Road, Chattogram",
               PhoneNumber = "01712345678",
               Email = "amit.roy@example.com",
               NationalId = "123456789012",
               PassportNumber = "A1234567",
               DateOfJoining = new DateTime(2020, 1, 10),
               ImagePath = "/images/amitroy.jpg",
               EmergencyContactNumber = "01823456789",
               FathersName = "Shankar Roy",
               MothersName = "Mina Roy",
               BloodGroup = "O+",
               Religion = "Hindu",
               MaritalStatus = "Single",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 1,
               DepartmentId = 1
           },
           new Employee
           {
               EmployeeId = 2,
               FirstName = "Rina",
               LastName = "Chakraborty",
               DateOfBirth = new DateTime(1985, 11, 22),
               Gender = "Female",
               PresentAddress = "789 Hill Street, Dhaka",
               PermanentAddress = "1012 Beach Road, Sylhet",
               PhoneNumber = "01787654321",
               Email = "rina.chakraborty@example.com",
               NationalId = "234567890123",
               PassportNumber = "B2345678",
               DateOfJoining = new DateTime(2019, 7, 15),
               ImagePath = "/images/rinachakraborty.jpg",
               EmergencyContactNumber = "01834567890",
               FathersName = "Kumar Chakraborty",
               MothersName = "Soma Chakraborty",
               BloodGroup = "A+",
               Religion = "Hindu",
               MaritalStatus = "Married",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 2,
               DepartmentId = 2
           },
           new Employee
           {
               EmployeeId = 3,
               FirstName = "Sanjay",
               LastName = "Ghosh",
               DateOfBirth = new DateTime(1988, 3, 30),
               Gender = "Male",
               PresentAddress = "123 Green Lane, Dhaka",
               PermanentAddress = "456 Blue Lane, Bogura",
               PhoneNumber = "01798765432",
               Email = "sanjay.ghosh@example.com",
               NationalId = "345678901234",
               PassportNumber = "C3456789",
               DateOfJoining = new DateTime(2018, 6, 20),
               ImagePath = "/images/sanjayghosh.jpg",
               EmergencyContactNumber = "01845678901",
               FathersName = "Suresh Ghosh",
               MothersName = "Anita Ghosh",
               BloodGroup = "B+",
               Religion = "Hindu",
               MaritalStatus = "Single",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 3,
               DepartmentId = 3
           },
           new Employee
           {
               EmployeeId = 4,
               FirstName = "Mina",
               LastName = "Das",
               DateOfBirth = new DateTime(1992, 8, 5),
               Gender = "Female",
               PresentAddress = "321 Market Street, Dhaka",
               PermanentAddress = "654 Park Avenue, Khulna",
               PhoneNumber = "01745678901",
               Email = "mina.das@example.com",
               NationalId = "456789012345",
               PassportNumber = "D4567890",
               DateOfJoining = new DateTime(2021, 4, 10),
               ImagePath = "/images/minadas.jpg",
               EmergencyContactNumber = "01856789012",
               FathersName = "Ramesh Das",
               MothersName = "Gita Das",
               BloodGroup = "AB+",
               Religion = "Hindu",
               MaritalStatus = "Divorced",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 4,
               DepartmentId = 4
           },
           new Employee
           {
               EmployeeId = 5,
               FirstName = "Arif",
               LastName = "Hossain",
               DateOfBirth = new DateTime(1987, 12, 12),
               Gender = "Male",
               PresentAddress = "789 Hill Top, Dhaka",
               PermanentAddress = "1012 Central Road, Rajshahi",
               PhoneNumber = "01712349876",
               Email = "arif.hossain@example.com",
               NationalId = "567890123456",
               PassportNumber = "E5678901",
               DateOfJoining = new DateTime(2022, 2, 25),
               ImagePath = "/images/arifhossain.jpg",
               EmergencyContactNumber = "01867890123",
               FathersName = "Mohammad Hossain",
               MothersName = "Fatema Hossain",
               BloodGroup = "O-",
               Religion = "Muslim",
               MaritalStatus = "Married",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 5,
               DepartmentId = 5
           },
           new Employee
           {
               EmployeeId = 6,
               FirstName = "Jaya",
               LastName = "Mukherjee",
               DateOfBirth = new DateTime(1995, 9, 19),
               Gender = "Female",
               PresentAddress = "456 Oak Street, Dhaka",
               PermanentAddress = "789 Maple Avenue, Moulvibazar",
               PhoneNumber = "01734567890",
               Email = "jaya.mukherjee@example.com",
               NationalId = "678901234567",
               PassportNumber = "F6789012",
               DateOfJoining = new DateTime(2023, 1, 5),
               ImagePath = "/images/jayamukherjee.jpg",
               EmergencyContactNumber = "01878901234",
               FathersName = "Dipak Mukherjee",
               MothersName = "Kakoli Mukherjee",
               BloodGroup = "AB-",
               Religion = "Hindu",
               MaritalStatus = "Single",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 6,
               DepartmentId = 6
           },
           new Employee
           {
               EmployeeId = 7,
               FirstName = "Rafiq",
               LastName = "Khan",
               DateOfBirth = new DateTime(1989, 7, 8),
               Gender = "Male",
               PresentAddress = "101 Pine Lane, Dhaka",
               PermanentAddress = "202 Cedar Road, Barishal",
               PhoneNumber = "01765432109",
               Email = "rafig.khan@example.com",
               NationalId = "789012345678",
               PassportNumber = "G7890123",
               DateOfJoining = new DateTime(2020, 9, 30),
               ImagePath = "/images/rafiqukhan.jpg",
               EmergencyContactNumber = "01889012345",
               FathersName = "Aziz Khan",
               MothersName = "Amina Khan",
               BloodGroup = "B-",
               Religion = "Muslim",
               MaritalStatus = "Widowed",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 7,
               DepartmentId = 7
           },
           new Employee
           {
               EmployeeId = 8,
               FirstName = "Sonali",
               LastName = "Saha",
               DateOfBirth = new DateTime(1991, 4, 16),
               Gender = "Female",
               PresentAddress = "234 Maple Street, Dhaka",
               PermanentAddress = "345 Pine Avenue, Sylhet",
               PhoneNumber = "01723456789",
               Email = "sonali.saha@example.com",
               NationalId = "890123456789",
               PassportNumber = "H8901234",
               DateOfJoining = new DateTime(2019, 12, 15),
               ImagePath = "/images/sonalisaha.jpg",
               EmergencyContactNumber = "01890123456",
               FathersName = "Babul Saha",
               MothersName = "Rina Saha",
               BloodGroup = "A-",
               Religion = "Hindu",
               MaritalStatus = "Married",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 8,
               DepartmentId = 8
           },
           new Employee
           {
               EmployeeId = 9,
               FirstName = "Imran",
               LastName = "Ahmed",
               DateOfBirth = new DateTime(1984, 6, 25),
               Gender = "Male",
               PresentAddress = "567 Birch Lane, Dhaka",
               PermanentAddress = "678 Elm Street, Rangpur",
               PhoneNumber = "01756789012",
               Email = "imran.ahmed@example.com",
               NationalId = "901234567890",
               PassportNumber = "I9012345",
               DateOfJoining = new DateTime(2018, 11, 10),
               ImagePath = "/images/imranahmed.jpg",
               EmergencyContactNumber = "01891234567",
               FathersName = "Mohammad Ahmed",
               MothersName = "Nasima Ahmed",
               BloodGroup = "O+",
               Religion = "Muslim",
               MaritalStatus = "Single",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 9,
               DepartmentId = 9
           },
           new Employee
           {
               EmployeeId = 10,
               FirstName = "Anita",
               LastName = "Bhattacharya",
               DateOfBirth = new DateTime(1993, 10, 3),
               Gender = "Female",
               PresentAddress = "890 Walnut Street, Dhaka",
               PermanentAddress = "123 Oak Road, Comilla",
               PhoneNumber = "01767890123",
               Email = "anita.bhattacharya@example.com",
               NationalId = "012345678901",
               PassportNumber = "J0123456",
               DateOfJoining = new DateTime(2022, 8, 25),
               ImagePath = "/images/anitabhattacharya.jpg",
               EmergencyContactNumber = "01893456789",
               FathersName = "Pranab Bhattacharya",
               MothersName = "Chitra Bhattacharya",
               BloodGroup = "AB+",
               Religion = "Hindu",
               MaritalStatus = "Married",
               Nationality = "Bangladeshi",
               IsActive = true,
               CreatedOn = DateTime.UtcNow,
               CreatedBy = "admin",
               UpdatedOn = DateTime.UtcNow,
               UpdatedBy = "admin",
               JobTitleId = 10,
               DepartmentId = 10
           }
       );


            // Seed data for EmployeeLifecycles
            modelBuilder.Entity<EmployeeLifecycle>().HasData(
                new EmployeeLifecycle { LifecycleId = 1, EmployeeId = 1, ActionType = "Onboarding", ActionDate = new DateTime(2010, 1, 1), IsActive = true },
                new EmployeeLifecycle { LifecycleId = 2, EmployeeId = 2, ActionType = "Onboarding", ActionDate = new DateTime(2015, 8, 15), IsActive = true },
                new EmployeeLifecycle { LifecycleId = 3, EmployeeId = 3, ActionType = "Onboarding", ActionDate = new DateTime(2008, 3, 5), IsActive = true },
                new EmployeeLifecycle { LifecycleId = 4, EmployeeId = 4, ActionType = "Onboarding", ActionDate = new DateTime(2019, 11, 12), IsActive = true },
                new EmployeeLifecycle { LifecycleId = 5, EmployeeId = 5, ActionType = "Onboarding", ActionDate = new DateTime(2012, 6, 30), IsActive = true },
                new EmployeeLifecycle { LifecycleId = 6, EmployeeId = 6, ActionType = "Onboarding", ActionDate = new DateTime(2016, 10, 20), IsActive = true },
                new EmployeeLifecycle { LifecycleId = 7, EmployeeId = 7, ActionType = "Onboarding", ActionDate = new DateTime(2005, 7, 18), IsActive = true },
                new EmployeeLifecycle { LifecycleId = 8, EmployeeId = 8, ActionType = "Onboarding", ActionDate = new DateTime(2020, 4, 22), IsActive = true },
                new EmployeeLifecycle { LifecycleId = 9, EmployeeId = 9, ActionType = "Onboarding", ActionDate = new DateTime(2018, 9, 3), IsActive = true },
                new EmployeeLifecycle { LifecycleId = 10, EmployeeId = 10, ActionType = "Onboarding", ActionDate = new DateTime(2013, 12, 10), IsActive = true }
            );

            // Seed data for EmployeeDataImportExports
            modelBuilder.Entity<EmployeeDataImportExport>().HasData(
             new EmployeeDataImportExport
             {
                 ImportExportId = 1,
                 Type = "Import",
                 DataPath = "/data/imports/employee_data_2023.csv",
                 ImportExportDate = new DateTime(2023, 6, 15),
                 IsActive = true
             },
             new EmployeeDataImportExport
             {
                 ImportExportId = 2,
                 Type = "Export",
                 DataPath = "/data/exports/employee_data_2023.xlsx",
                 ImportExportDate = new DateTime(2023, 7, 20),
                 IsActive = true
             },
             new EmployeeDataImportExport
             {
                 ImportExportId = 3,
                 Type = "Import",
                 DataPath = "/data/imports/employee_data_2023_part2.csv",
                 ImportExportDate = new DateTime(2023, 8, 10),
                 IsActive = true
             },
             new EmployeeDataImportExport
             {
                 ImportExportId = 4,
                 Type = "Export",
                 DataPath = "/data/exports/employee_data_backup_2023.csv",
                 ImportExportDate = new DateTime(2023, 9, 25),
                 IsActive = true
             },
             new EmployeeDataImportExport
             {
                 ImportExportId = 5,
                 Type = "Import",
                 DataPath = "/data/imports/employee_data_new_records.csv",
                 ImportExportDate = new DateTime(2023, 10, 15),
                 IsActive = true
             },
             new EmployeeDataImportExport
             {
                 ImportExportId = 6,
                 Type = "Export",
                 DataPath = "/data/exports/employee_data_summary_2023.xlsx",
                 ImportExportDate = new DateTime(2023, 11, 5),
                 IsActive = true
             },
             new EmployeeDataImportExport
             {
                 ImportExportId = 7,
                 Type = "Import",
                 DataPath = "/data/imports/employee_attendance_data_2023.csv",
                 ImportExportDate = new DateTime(2024, 1, 10),
                 IsActive = true
             },
             new EmployeeDataImportExport
             {
                 ImportExportId = 8,
                 Type = "Export",
                 DataPath = "/data/exports/employee_performance_data_2023.xlsx",
                 ImportExportDate = new DateTime(2024, 2, 20),
                 IsActive = true
             },
             new EmployeeDataImportExport
             {
                 ImportExportId = 9,
                 Type = "Import",
                 DataPath = "/data/imports/employee_salary_data_2023.csv",
                 ImportExportDate = new DateTime(2024, 3, 5),
                 IsActive = true
             },
             new EmployeeDataImportExport
             {
                 ImportExportId = 10,
                 Type = "Export",
                 DataPath = "/data/exports/employee_data_full_2023.xlsx",
                 ImportExportDate = new DateTime(2024, 4, 15),
                 IsActive = true
             }
         );

            #endregion SeedDataForEmpoyeeMangement

            #region SeedForTimeAndAttendence
            // Seed data for AbsenceReport
            modelBuilder.Entity<AbsenceReport>().HasData(
     new AbsenceReport
     {
         AbsenceReportId = 1,
         EmployeeId = 1,
         StartDate = new DateTime(2024, 8, 1),
         EndDate = new DateTime(2024, 8, 2),
         Reason = "Medical Leave",
         Approver = "John Doe",
         Status = "Approved",
         IsPaid = true,
         ApprovedDate = new DateTime(2024, 8, 3, 10, 30, 0),
         IsHalfDay = false,
         HalfDayType = "None",
         DaysAbsent = 2.0m
     },
     new AbsenceReport
     {
         AbsenceReportId = 2,
         EmployeeId = 2,
         StartDate = new DateTime(2024, 7, 15),
         EndDate = new DateTime(2024, 7, 15),
         Reason = "Personal Leave",
         Approver = "Jane Smith",
         Status = "Approved",
         IsPaid = false,
         ApprovedDate = new DateTime(2024, 7, 14, 9, 0, 0),
         IsHalfDay = true,
         HalfDayType = "Morning",
         DaysAbsent = 0.5m
     },
     new AbsenceReport
     {
         AbsenceReportId = 3,
         EmployeeId = 3,
         StartDate = new DateTime(2024, 8, 3),
         EndDate = new DateTime(2024, 8, 5),
         Reason = "Family Emergency",
         Approver = "John Doe",
         Status = "Pending",
         IsPaid = false,
         ApprovedDate = new DateTime(2024, 8, 6, 14, 15, 0),
         IsHalfDay = false,
         HalfDayType = "None",
         DaysAbsent = 3.0m
     },
     new AbsenceReport
     {
         AbsenceReportId = 4,
         EmployeeId = 4,
         StartDate = new DateTime(2024, 7, 20),
         EndDate = new DateTime(2024, 7, 21),
         Reason = "Sick Leave",
         Approver = "Jane Smith",
         Status = "Approved",
         IsPaid = true,
         ApprovedDate = new DateTime(2024, 7, 22, 11, 0, 0),
         IsHalfDay = false,
         HalfDayType = "None",
         DaysAbsent = 2.0m
     },
     new AbsenceReport
     {
         AbsenceReportId = 5,
         EmployeeId = 5,
         StartDate = new DateTime(2024, 8, 10),
         EndDate = new DateTime(2024, 8, 10),
         Reason = "Doctor's Appointment",
         Approver = "John Doe",
         Status = "Approved",
         IsPaid = false,
         ApprovedDate = new DateTime(2024, 8, 10, 12, 0, 0),
         IsHalfDay = true,
         HalfDayType = "Afternoon",
         DaysAbsent = 0.5m
     },
     new AbsenceReport
     {
         AbsenceReportId = 6,
         EmployeeId = 6,
         StartDate = new DateTime(2024, 7, 30),
         EndDate = new DateTime(2024, 7, 31),
         Reason = "Vacation",
         Approver = "Jane Smith",
         Status = "Approved",
         IsPaid = true,
         ApprovedDate = new DateTime(2024, 7, 29, 9, 30, 0),
         IsHalfDay = false,
         HalfDayType = "None",
         DaysAbsent = 2.0m
     },
     new AbsenceReport
     {
         AbsenceReportId = 7,
         EmployeeId = 7,
         StartDate = new DateTime(2024, 8, 5),
         EndDate = new DateTime(2024, 8, 6),
         Reason = "Jury Duty",
         Approver = "John Doe",
         Status = "Approved",
         IsPaid = true,
         ApprovedDate = new DateTime(2024, 8, 7, 15, 0, 0),
         IsHalfDay = false,
         HalfDayType = "None",
         DaysAbsent = 2.0m
     },
     new AbsenceReport
     {
         AbsenceReportId = 8,
         EmployeeId = 8,
         StartDate = new DateTime(2024, 8, 15),
         EndDate = new DateTime(2024, 8, 15),
         Reason = "Bereavement Leave",
         Approver = "Jane Smith",
         Status = "Pending",
         IsPaid = false,
         ApprovedDate = new DateTime(2024, 8, 16, 10, 0, 0),
         IsHalfDay = true,
         HalfDayType = "Morning",
         DaysAbsent = 0.5m
     },
     new AbsenceReport
     {
         AbsenceReportId = 9,
         EmployeeId = 9,
         StartDate = new DateTime(2024, 7, 25),
         EndDate = new DateTime(2024, 7, 26),
         Reason = "Travel",
         Approver = "John Doe",
         Status = "Approved",
         IsPaid = false,
         ApprovedDate = new DateTime(2024, 7, 27, 13, 30, 0),
         IsHalfDay = false,
         HalfDayType = "None",
         DaysAbsent = 2.0m
     },
     new AbsenceReport
     {
         AbsenceReportId = 10,
         EmployeeId = 10,
         StartDate = new DateTime(2024, 8, 7),
         EndDate = new DateTime(2024, 8, 8),
         Reason = "Training",
         Approver = "Jane Smith",
         Status = "Approved",
         IsPaid = true,
         ApprovedDate = new DateTime(2024, 8, 9, 10, 45, 0),
         IsHalfDay = false,
         HalfDayType = "None",
         DaysAbsent = 2.0m
     }
 );


            // Seed data for ClockInOut
            modelBuilder.Entity<ClockInOut>().HasData(
    new ClockInOut
    {
        ClockInOutId = 1,
        EmployeeId = 1,
        Timestamp = new DateTime(2024, 8, 1, 8, 0, 0),
        Action = "ClockIn",
        Location = "Office A",
        Notes = "Normal day",
        ClockInTime = new DateTime(2024, 8, 1, 8, 0, 0),
        ClockOutTime = new DateTime(2024, 8, 1, 17, 0, 0),
        IsLateArrival = false,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0m,
        IsOvertime = false,
        ApprovedBy = "John Doe",
        IsActive = true,
        LateArrivalReason = "",
        EarlyDepartureReason = null
    },
    new ClockInOut
    {
        ClockInOutId = 2,
        EmployeeId = 2,
        Timestamp = new DateTime(2024, 8, 2, 8, 30, 0),
        Action = "ClockIn",
        Location = "Office B",
        Notes = "Late arrival due to traffic",
        ClockInTime = new DateTime(2024, 8, 2, 8, 30, 0),
        ClockOutTime = new DateTime(2024, 8, 2, 17, 30, 0),
        IsLateArrival = true,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0.5m,
        IsOvertime = true,
        ApprovedBy = "Jane Smith",
        IsActive = true,
        LateArrivalReason = "Traffic",
        EarlyDepartureReason = null
    },
    new ClockInOut
    {
        ClockInOutId = 3,
        EmployeeId = 3,
        Timestamp = new DateTime(2024, 8, 3, 7, 45, 0),
        Action = "ClockIn",
        Location = "Remote",
        Notes = "Working from home",
        ClockInTime = new DateTime(2024, 8, 3, 7, 45, 0),
        ClockOutTime = new DateTime(2024, 8, 3, 16, 45, 0),
        IsLateArrival = false,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0m,
        IsOvertime = false,
        ApprovedBy = "Emily Johnson",
        IsActive = true,
        LateArrivalReason = "",
        EarlyDepartureReason = null
    },
    new ClockInOut
    {
        ClockInOutId = 4,
        EmployeeId = 4,
        Timestamp = new DateTime(2024, 8, 4, 8, 15, 0),
        Action = "ClockIn",
        Location = "Office C",
        Notes = "Late due to doctor's appointment",
        ClockInTime = new DateTime(2024, 8, 4, 8, 15, 0),
        ClockOutTime = new DateTime(2024, 8, 4, 17, 15, 0),
        IsLateArrival = true,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0.25m,
        IsOvertime = true,
        ApprovedBy = "Michael Brown",
        IsActive = true,
        LateArrivalReason = "Doctor's appointment",
        EarlyDepartureReason = null
    },
    new ClockInOut
    {
        ClockInOutId = 5,
        EmployeeId = 5,
        Timestamp = new DateTime(2024, 8, 5, 7, 55, 0),
        Action = "ClockIn",
        Location = "Office A",
        Notes = "Arrived early",
        ClockInTime = new DateTime(2024, 8, 5, 7, 55, 0),
        ClockOutTime = new DateTime(2024, 8, 5, 17, 5, 0),
        IsLateArrival = false,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0.17m,
        IsOvertime = true,
        ApprovedBy = "David Wilson",
        IsActive = true,
        LateArrivalReason = "",
        EarlyDepartureReason = null
    },
    new ClockInOut
    {
        ClockInOutId = 6,
        EmployeeId = 6,
        Timestamp = new DateTime(2024, 8, 6, 8, 5, 0),
        Action = "ClockIn",
        Location = "Remote",
        Notes = "Late due to family emergency",
        ClockInTime = new DateTime(2024, 8, 6, 8, 5, 0),
        ClockOutTime = new DateTime(2024, 8, 6, 16, 5, 0),
        IsLateArrival = true,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0m,
        IsOvertime = false,
        ApprovedBy = "John Doe",
        IsActive = true,
        LateArrivalReason = "Family emergency",
        EarlyDepartureReason = null
    },
    new ClockInOut
    {
        ClockInOutId = 7,
        EmployeeId = 7,
        Timestamp = new DateTime(2024, 8, 7, 8, 10, 0),
        Action = "ClockIn",
        Location = "Office B",
        Notes = "Slight delay due to transport issues",
        ClockInTime = new DateTime(2024, 8, 7, 8, 10, 0),
        ClockOutTime = new DateTime(2024, 8, 7, 17, 10, 0),
        IsLateArrival = true,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0.17m,
        IsOvertime = true,
        ApprovedBy = "Jane Smith",
        IsActive = true,
        LateArrivalReason = "Transport issues",
        EarlyDepartureReason = null
    },
    new ClockInOut
    {
        ClockInOutId = 8,
        EmployeeId = 8,
        Timestamp = new DateTime(2024, 8, 8, 8, 0, 0),
        Action = "ClockIn",
        Location = "Office C",
        Notes = "Normal clock-in",
        ClockInTime = new DateTime(2024, 8, 8, 8, 0, 0),
        ClockOutTime = new DateTime(2024, 8, 8, 17, 0, 0),
        IsLateArrival = false,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0m,
        IsOvertime = false,
        ApprovedBy = "Emily Johnson",
        IsActive = true,
        LateArrivalReason = "",
        EarlyDepartureReason = null
    },
    new ClockInOut
    {
        ClockInOutId = 9,
        EmployeeId = 9,
        Timestamp = new DateTime(2024, 8, 9, 7, 50, 0),
        Action = "ClockIn",
        Location = "Remote",
        Notes = "Early clock-in",
        ClockInTime = new DateTime(2024, 8, 9, 7, 50, 0),
        ClockOutTime = new DateTime(2024, 8, 9, 16, 50, 0),
        IsLateArrival = false,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0.17m,
        IsOvertime = true,
        ApprovedBy = "Michael Brown",
        IsActive = true,
        LateArrivalReason = "",
        EarlyDepartureReason = null
    },
    new ClockInOut
    {
        ClockInOutId = 10,
        EmployeeId = 10,
        Timestamp = new DateTime(2024, 8, 10, 8, 20, 0),
        Action = "ClockIn",
        Location = "Office A",
        Notes = "Late due to personal reasons",
        ClockInTime = new DateTime(2024, 8, 10, 8, 20, 0),
        ClockOutTime = new DateTime(2024, 8, 10, 17, 20, 0),
        IsLateArrival = true,
        IsEarlyDeparture = false,
        IsWorkday = true,
        OvertimeHours = 0.17m,
        IsOvertime = true,
        ApprovedBy = "David Wilson",
        IsActive = true,
        LateArrivalReason = "Personal reasons",
        EarlyDepartureReason = null
    }
);
            // Seed data for Leave
            modelBuilder.Entity<Leave>().HasData(
     new Leave
     {
         LeaveId = 1,
         EmployeeId = 1,
         LeaveType = "Sick Leave",
         StartDate = new DateTime(2024, 8, 1),
         EndDate = new DateTime(2024, 8, 3),
         Status = "Approved",
         Reason = "Fever and cold",
         RequestedBy = "John Doe",
         ApprovalDate = new DateTime(2024, 7, 31, 10, 0, 0),
         Approver = "Jane Smith",
         ApprovalComments = "Take care",
         IsActive = true,
         IsPaidLeave = true,
         LeaveCategory = "Sick Leave",
         NumberOfDays = 3.0m
     },
     new Leave
     {
         LeaveId = 2,
         EmployeeId = 2,
         LeaveType = "Vacation",
         StartDate = new DateTime(2024, 7, 15),
         EndDate = new DateTime(2024, 7, 20),
         Status = "Approved",
         Reason = "Family vacation",
         RequestedBy = "Jane Smith",
         ApprovalDate = new DateTime(2024, 7, 10, 14, 30, 0),
         Approver = "John Doe",
         ApprovalComments = "Enjoy your time",
         IsActive = true,
         IsPaidLeave = true,
         LeaveCategory = "Vacation Leave",
         NumberOfDays = 6.0m
     },
     new Leave
     {
         LeaveId = 3,
         EmployeeId = 3,
         LeaveType = "Maternity Leave",
         StartDate = new DateTime(2024, 9, 1),
         EndDate = new DateTime(2024, 12, 1),
         Status = "Pending",
         Reason = "Maternity",
         RequestedBy = "Emily Clark",
         ApprovalDate = new DateTime(2024, 8, 20, 9, 0, 0),
         Approver = "Jane Smith",
         ApprovalComments = "Pending approval",
         IsActive = false,
         IsPaidLeave = true,
         LeaveCategory = "Maternity Leave",
         NumberOfDays = 9.0m
     },
     new Leave
     {
         LeaveId = 4,
         EmployeeId = 4,
         LeaveType = "Bereavement Leave",
         StartDate = new DateTime(2024, 8, 10),
         EndDate = new DateTime(2024, 8, 15),
         Status = "Approved",
         Reason = "Loss of family member",
         RequestedBy = "Michael Brown",
         ApprovalDate = new DateTime(2024, 8, 8, 16, 0, 0),
         Approver = "John Doe",
         ApprovalComments = "Condolences",
         IsActive = true,
         IsPaidLeave = true,
         LeaveCategory = "Bereavement Leave",
         NumberOfDays = 6.0m
     },
     new Leave
     {
         LeaveId = 5,
         EmployeeId = 5,
         LeaveType = "Sick Leave",
         StartDate = new DateTime(2024, 7, 25),
         EndDate = new DateTime(2024, 7, 26),
         Status = "Approved",
         Reason = "Migraine",
         RequestedBy = "Sarah Johnson",
         ApprovalDate = new DateTime(2024, 7, 24, 10, 15, 0),
         Approver = "Jane Smith",
         ApprovalComments = "Get well soon",
         IsActive = true,
         IsPaidLeave = true,
         LeaveCategory = "Sick Leave",
         NumberOfDays = 2.0m
     },
     new Leave
     {
         LeaveId = 6,
         EmployeeId = 6,
         LeaveType = "Vacation",
         StartDate = new DateTime(2024, 8, 20),
         EndDate = new DateTime(2024, 8, 25),
         Status = "Approved",
         Reason = "Holiday trip",
         RequestedBy = "David Williams",
         ApprovalDate = new DateTime(2024, 8, 15, 11, 30, 0),
         Approver = "John Doe",
         ApprovalComments = "Safe travels",
         IsActive = true,
         IsPaidLeave = true,
         LeaveCategory = "Vacation Leave",
         NumberOfDays = 6.0m
     },
     new Leave
     {
         LeaveId = 7,
         EmployeeId = 7,
         LeaveType = "Sick Leave",
         StartDate = new DateTime(2024, 7, 30),
         EndDate = new DateTime(2024, 7, 31),
         Status = "Approved",
         Reason = "Back pain",
         RequestedBy = "James White",
         ApprovalDate = new DateTime(2024, 7, 29, 14, 45, 0),
         Approver = "Jane Smith",
         ApprovalComments = "Take rest",
         IsActive = true,
         IsPaidLeave = true,
         LeaveCategory = "Sick Leave",
         NumberOfDays = 2.0m
     },
     new Leave
     {
         LeaveId = 8,
         EmployeeId = 8,
         LeaveType = "Paternity Leave",
         StartDate = new DateTime(2024, 9, 5),
         EndDate = new DateTime(2024, 9, 19),
         Status = "Approved",
         Reason = "Newborn care",
         RequestedBy = "Robert Green",
         ApprovalDate = new DateTime(2024, 9, 3, 10, 0, 0),
         Approver = "John Doe",
         ApprovalComments = "Congrats!",
         IsActive = true,
         IsPaidLeave = true,
         LeaveCategory = "Paternity Leave",
         NumberOfDays = 15.0m
     },
     new Leave
     {
         LeaveId = 9,
         EmployeeId = 9,
         LeaveType = "Sick Leave",
         StartDate = new DateTime(2024, 8, 2),
         EndDate = new DateTime(2024, 8, 4),
         Status = "Approved",
         Reason = "Flu",
         RequestedBy = "William Black",
         ApprovalDate = new DateTime(2024, 8, 1, 9, 30, 0),
         Approver = "Jane Smith",
         ApprovalComments = "Take care",
         IsActive = true,
         IsPaidLeave = true,
         LeaveCategory = "Sick Leave",
         NumberOfDays = 3.0m
     },
     new Leave
     {
         LeaveId = 10,
         EmployeeId = 10,
         LeaveType = "Vacation",
         StartDate = new DateTime(2024, 8, 25),
         EndDate = new DateTime(2024, 8, 30),
         Status = "Approved",
         Reason = "Beach holiday",
         RequestedBy = "Jessica King",
         ApprovalDate = new DateTime(2024, 8, 20, 12, 15, 0),
         Approver = "John Doe",
         ApprovalComments = "Enjoy your time off",
         IsActive = true,
         IsPaidLeave = true,
         LeaveCategory = "Vacation Leave",
         NumberOfDays = 6.0m
     }
 );


            // Seed data for Overtime
            modelBuilder.Entity<Overtime>().HasData(
                new Overtime { OvertimeId = 1, EmployeeId = 1, Date = new DateTime(2024, 08, 01), Hours = 4.5M, IsActive = true, OvertimeType = "Voluntary", ApprovalStatus = "Approved", ApprovedBy = "Jane Smith", ApprovalDate = DateTime.Now, Reason = "Project deadline", AttachmentUrl = "http://example.com/attachment1", CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "John Doe", LastModifiedBy = "John Doe", Department = "IT", Project = "Project A" },
                new Overtime { OvertimeId = 2, EmployeeId = 2, Date = new DateTime(2024, 08, 03), Hours = 3.0M, IsActive = true, OvertimeType = "Mandatory", ApprovalStatus = "Pending", ApprovedBy = null, ApprovalDate = null, Reason = "System update", AttachmentUrl = null, CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "Alice Johnson", LastModifiedBy = "Alice Johnson", Department = "Finance", Project = "System Upgrade" },
                new Overtime { OvertimeId = 3, EmployeeId = 3, Date = new DateTime(2024, 08, 05), Hours = 2.0M, IsActive = true, OvertimeType = "Voluntary", ApprovalStatus = "Approved", ApprovedBy = "Michael Brown", ApprovalDate = DateTime.Now, Reason = "Customer support", AttachmentUrl = "http://example.com/attachment2", CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "Emily Davis", LastModifiedBy = "Emily Davis", Department = "Support", Project = "Customer A" },
                new Overtime { OvertimeId = 4, EmployeeId = 4, Date = new DateTime(2024, 08, 10), Hours = 5.0M, IsActive = true, OvertimeType = "Mandatory", ApprovalStatus = "Approved", ApprovedBy = "Sarah Johnson", ApprovalDate = DateTime.Now, Reason = "Product launch", AttachmentUrl = "http://example.com/attachment3", CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "David Wilson", LastModifiedBy = "David Wilson", Department = "Marketing", Project = "Launch X" },
                new Overtime { OvertimeId = 5, EmployeeId = 5, Date = new DateTime(2024, 08, 12), Hours = 6.0M, IsActive = true, OvertimeType = "Voluntary", ApprovalStatus = "Rejected", ApprovedBy = null, ApprovalDate = null, Reason = "Training preparation", AttachmentUrl = null, CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "Jessica Lee", LastModifiedBy = "Jessica Lee", Department = "HR", Project = "Training Session" },
                new Overtime { OvertimeId = 6, EmployeeId = 6, Date = new DateTime(2024, 08, 15), Hours = 4.0M, IsActive = true, OvertimeType = "Voluntary", ApprovalStatus = "Approved", ApprovedBy = "Robert Brown", ApprovalDate = DateTime.Now, Reason = "Client meeting", AttachmentUrl = "http://example.com/attachment4", CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "Mark Taylor", LastModifiedBy = "Mark Taylor", Department = "Sales", Project = "Meeting Y" },
                new Overtime { OvertimeId = 7, EmployeeId = 7, Date = new DateTime(2024, 08, 18), Hours = 2.5M, IsActive = true, OvertimeType = "Mandatory", ApprovalStatus = "Pending", ApprovedBy = null, ApprovalDate = null, Reason = "Audit preparation", AttachmentUrl = null, CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "Anna Scott", LastModifiedBy = "Anna Scott", Department = "Audit", Project = "Audit Z" },
                new Overtime { OvertimeId = 8, EmployeeId = 8, Date = new DateTime(2024, 08, 20), Hours = 3.5M, IsActive = true, OvertimeType = "Voluntary", ApprovalStatus = "Approved", ApprovedBy = "Olivia White", ApprovalDate = DateTime.Now, Reason = "Additional tasks", AttachmentUrl = "http://example.com/attachment5", CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "John Martin", LastModifiedBy = "John Martin", Department = "Operations", Project = "Task A" },
                new Overtime { OvertimeId = 9, EmployeeId = 9, Date = new DateTime(2024, 08, 22), Hours = 5.0M, IsActive = true, OvertimeType = "Mandatory", ApprovalStatus = "Approved", ApprovedBy = "James Miller", ApprovalDate = DateTime.Now, Reason = "Emergency response", AttachmentUrl = "http://example.com/attachment6", CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "Laura Clark", LastModifiedBy = "Laura Clark", Department = "Emergency", Project = "Response X" },
                new Overtime { OvertimeId = 10, EmployeeId = 10, Date = new DateTime(2024, 08, 25), Hours = 4.5M, IsActive = true, OvertimeType = "Voluntary", ApprovalStatus = "Approved", ApprovedBy = "Daniel Moore", ApprovalDate = DateTime.Now, Reason = "Extra support", AttachmentUrl = "http://example.com/attachment7", CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now, CreatedBy = "Sophia Walker", LastModifiedBy = "Sophia Walker", Department = "Customer Service", Project = "Support B" }
            );

            // Seed data for PayrollIntegration
            modelBuilder.Entity<PayrollIntegration>().HasData(
                new PayrollIntegration { PayrollIntegrationId = 1, EmployeeId = 1, PayrollSystemId = 101, Amount = 2500.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12345", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 150.00m, NetPay = 2350.00m, TaxAmount = 200.00m, GrossPay = 2550.00m },
                new PayrollIntegration { PayrollIntegrationId = 2, EmployeeId = 2, PayrollSystemId = 102, Amount = 3000.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12346", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 200.00m, NetPay = 2800.00m, TaxAmount = 250.00m, GrossPay = 3050.00m },
                new PayrollIntegration { PayrollIntegrationId = 3, EmployeeId = 3, PayrollSystemId = 103, Amount = 2700.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12347", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 180.00m, NetPay = 2520.00m, TaxAmount = 220.00m, GrossPay = 2740.00m },
                new PayrollIntegration { PayrollIntegrationId = 4, EmployeeId = 4, PayrollSystemId = 104, Amount = 2900.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12348", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 210.00m, NetPay = 2690.00m, TaxAmount = 230.00m, GrossPay = 2920.00m },
                new PayrollIntegration { PayrollIntegrationId = 5, EmployeeId = 5, PayrollSystemId = 105, Amount = 3200.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12349", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 230.00m, NetPay = 2970.00m, TaxAmount = 270.00m, GrossPay = 3240.00m },
                new PayrollIntegration { PayrollIntegrationId = 6, EmployeeId = 6, PayrollSystemId = 106, Amount = 3100.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12350", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 220.00m, NetPay = 2880.00m, TaxAmount = 260.00m, GrossPay = 3140.00m },
                new PayrollIntegration { PayrollIntegrationId = 7, EmployeeId = 7, PayrollSystemId = 107, Amount = 2800.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12351", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 190.00m, NetPay = 2610.00m, TaxAmount = 240.00m, GrossPay = 2850.00m },
                new PayrollIntegration { PayrollIntegrationId = 8, EmployeeId = 8, PayrollSystemId = 108, Amount = 3300.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12352", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 240.00m, NetPay = 3060.00m, TaxAmount = 280.00m, GrossPay = 3340.00m },
                new PayrollIntegration { PayrollIntegrationId = 9, EmployeeId = 9, PayrollSystemId = 109, Amount = 3500.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12353", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 250.00m, NetPay = 3250.00m, TaxAmount = 290.00m, GrossPay = 3550.00m },
                new PayrollIntegration { PayrollIntegrationId = 10, EmployeeId = 10, PayrollSystemId = 110, Amount = 3400.00m, IntegrationDate = new DateTime(2024, 08, 01), IntegrationType = "Regular", TransactionId = "TX12354", IsActive = true, PayPeriodStartDate = new DateTime(2024, 08, 01), PayPeriodEndDate = new DateTime(2024, 08, 31), PayFrequency = "Monthly", Deductions = 230.00m, NetPay = 3170.00m, TaxAmount = 270.00m, GrossPay = 3440.00m }
            );
            #endregion SeedForTimeAndAttendence

            #region SeedDataForRecruitmentManagement
            // Configuring the Status enum as a string in the database
            modelBuilder.Entity<Applicant>()
                .Property(e => e.Status)
                .HasConversion<string>();

            // Configure Applicant - Education relationship
            modelBuilder.Entity<Education>()
                .HasOne(e => e.Applicant)
                .WithMany(a => a.Educations)
                .HasForeignKey(e => e.ApplicantId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Applicant - WorkExperience relationship
            modelBuilder.Entity<WorkExperience>()
                .HasOne(w => w.Applicant)
                .WithMany(a => a.WorkExperiences)
                .HasForeignKey(w => w.ApplicantId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed data for Applicants
            modelBuilder.Entity<Applicant>().HasData(
                new Applicant
                {
                    ApplicantId = 1,
                    ApplicantName = "John Doe",
                    Email = "john.doe@example.com",
                    ResumeUrl = "https://example.com/resume/johndoe.pdf",
                    Status = Applicant.Statuses.Approved,
                    AppliedDate = new DateTime(2024, 08, 01),
                    PhoneNumber = "123-456-7890",
                    LinkedinProfileUrl = "https://linkedin.com/in/johndoe",
                    Address = "123 Main St",
                    City = "New York",
                    ZipCode = "10001",
                    Country = "USA",
                    ExpectedSalary = 70000m,
                    Languages = "English, Spanish",
                    Skills = "C#, .NET, SQL",
                    References = "Available upon request"
                },
                new Applicant
                {
                    ApplicantId = 2,
                    ApplicantName = "Alice Johnson",
                    Email = "alice.johnson@example.com",
                    ResumeUrl = "https://example.com/resume/alicejohnson.pdf",
                    Status = Applicant.Statuses.Pending,
                    AppliedDate = new DateTime(2024, 08, 05),
                    PhoneNumber = "234-567-8901",
                    LinkedinProfileUrl = "https://linkedin.com/in/alicejohnson",
                    Address = "456 Oak St",
                    City = "San Francisco",
                    ZipCode = "94101",
                    Country = "USA",
                    ExpectedSalary = 80000m,
                    Languages = "English, Mandarin",
                    Skills = "JavaScript, React, Node.js",
                    References = "Available upon request"
                },
                new Applicant
                {
                    ApplicantId = 3,
                    ApplicantName = "Robert Smith",
                    Email = "robert.smith@example.com",
                    ResumeUrl = "https://example.com/resume/robertsmith.pdf",
                    Status = Applicant.Statuses.Approved,
                    AppliedDate = new DateTime(2024, 08, 07),
                    PhoneNumber = "345-678-9012",
                    LinkedinProfileUrl = "https://linkedin.com/in/robertsmith",
                    Address = "789 Pine St",
                    City = "Los Angeles",
                    ZipCode = "90001",
                    Country = "USA",
                    ExpectedSalary = 90000m,
                    Languages = "English, French",
                    Skills = "Python, Django, Flask",
                    References = "Available upon request"
                },
                new Applicant
                {
                    ApplicantId = 4,
                    ApplicantName = "Emily Davis",
                    Email = "emily.davis@example.com",
                    ResumeUrl = "https://example.com/resume/emilydavis.pdf",
                    Status = Applicant.Statuses.Rejected,
                    AppliedDate = new DateTime(2024, 08, 10),
                    PhoneNumber = "456-789-0123",
                    LinkedinProfileUrl = "https://linkedin.com/in/emilydavis",
                    Address = "101 Maple St",
                    City = "Chicago",
                    ZipCode = "60601",
                    Country = "USA",
                    ExpectedSalary = 85000m,
                    Languages = "English, German",
                    Skills = "Java, Spring, Hibernate",
                    References = "Available upon request"
                },
                new Applicant
                {
                    ApplicantId = 5,
                    ApplicantName = "Michael Brown",
                    Email = "michael.brown@example.com",
                    ResumeUrl = "https://example.com/resume/michaelbrown.pdf",
                    Status = Applicant.Statuses.Pending,
                    AppliedDate = new DateTime(2024, 08, 12),
                    PhoneNumber = "567-890-1234",
                    LinkedinProfileUrl = "https://linkedin.com/in/michaelbrown",
                    Address = "202 Cedar St",
                    City = "Houston",
                    ZipCode = "77001",
                    Country = "USA",
                    ExpectedSalary = 75000m,
                    Languages = "English, Japanese",
                    Skills = "C++, Unreal Engine, Game Development",
                    References = "Available upon request"
                },
                new Applicant
                {
                    ApplicantId = 6,
                    ApplicantName = "Sophia Martinez",
                    Email = "sophia.martinez@example.com",
                    ResumeUrl = "https://example.com/resume/sophiamartinez.pdf",
                    Status = Applicant.Statuses.Approved,
                    AppliedDate = new DateTime(2024, 08, 15),
                    PhoneNumber = "678-901-2345",
                    LinkedinProfileUrl = "https://linkedin.com/in/sophiamartinez",
                    Address = "303 Spruce St",
                    City = "Phoenix",
                    ZipCode = "85001",
                    Country = "USA",
                    ExpectedSalary = 78000m,
                    Languages = "English, Italian",
                    Skills = "Ruby on Rails, PostgreSQL, DevOps",
                    References = "Available upon request"
                },
                new Applicant
                {
                    ApplicantId = 7,
                    ApplicantName = "David Lee",
                    Email = "david.lee@example.com",
                    ResumeUrl = "https://example.com/resume/davidlee.pdf",
                    Status = Applicant.Statuses.Rejected,
                    AppliedDate = new DateTime(2024, 08, 18),
                    PhoneNumber = "789-012-3456",
                    LinkedinProfileUrl = "https://linkedin.com/in/davidlee",
                    Address = "404 Birch St",
                    City = "Miami",
                    ZipCode = "33101",
                    Country = "USA",
                    ExpectedSalary = 82000m,
                    Languages = "English, Korean",
                    Skills = "Go, Kubernetes, Microservices",
                    References = "Available upon request"
                },
                new Applicant
                {
                    ApplicantId = 8,
                    ApplicantName = "Olivia Wilson",
                    Email = "olivia.wilson@example.com",
                    ResumeUrl = "https://example.com/resume/oliviawilson.pdf",
                    Status = Applicant.Statuses.Pending,
                    AppliedDate = new DateTime(2024, 08, 20),
                    PhoneNumber = "890-123-4567",
                    LinkedinProfileUrl = "https://linkedin.com/in/oliviawilson",
                    Address = "505 Ash St",
                    City = "Seattle",
                    ZipCode = "98101",
                    Country = "USA",
                    ExpectedSalary = 77000m,
                    Languages = "English, Spanish",
                    Skills = "Swift, iOS Development, UI/UX Design",
                    References = "Available upon request"
                },
                new Applicant
                {
                    ApplicantId = 9,
                    ApplicantName = "William Taylor",
                    Email = "william.taylor@example.com",
                    ResumeUrl = "https://example.com/resume/williamtaylor.pdf",
                    Status = Applicant.Statuses.Approved,
                    AppliedDate = new DateTime(2024, 08, 23),
                    PhoneNumber = "901-234-5678",
                    LinkedinProfileUrl = "https://linkedin.com/in/williamtaylor",
                    Address = "606 Poplar St",
                    City = "Boston",
                    ZipCode = "02101",
                    Country = "USA",
                    ExpectedSalary = 90000m,
                    Languages = "English, Portuguese",
                    Skills = "JavaScript, Angular, Node.js",
                    References = "Available upon request"
                },
                new Applicant
                {
                    ApplicantId = 10,
                    ApplicantName = "Charlotte Harris",
                    Email = "charlotte.harris@example.com",
                    ResumeUrl = "https://example.com/resume/charlotteharris.pdf",
                    Status = Applicant.Statuses.Pending,
                    AppliedDate = new DateTime(2024, 08, 25),
                    PhoneNumber = "012-345-6789",
                    LinkedinProfileUrl = "https://linkedin.com/in/charlotteharris",
                    Address = "707 Willow St",
                    City = "Dallas",
                    ZipCode = "75201",
                    Country = "USA",
                    ExpectedSalary = 84000m,
                    Languages = "English, Russian",
                    Skills = "PHP, Laravel, MySQL",
                    References = "Available upon request"
                }
            );



            // Seed data for Education
            modelBuilder.Entity<Education>().HasData(
     new Education
     {
         EducationId = 1,
         ApplicantId = 1,  // Matches ApplicantId from Applicants table
         Degree = "Bachelor's Degree",
         Institution = "University A",
         PassingYear = "2020",
         Result = 3.5m
     },
     new Education
     {
         EducationId = 2,
         ApplicantId = 2,  // Matches ApplicantId from Applicants table
         Degree = "Master's Degree",
         Institution = "University B",
         PassingYear = "2022",
         Result = 3.8m
     },
     new Education
     {
         EducationId = 3,
         ApplicantId = 3,  // Matches ApplicantId from Applicants table
         Degree = "PhD",
         Institution = "University C",
         PassingYear = "2024",
         Result = 4.0m
     },
     new Education
     {
         EducationId = 4,
         ApplicantId = 4,  // Matches ApplicantId from Applicants table
         Degree = "Associate's Degree",
         Institution = "College D",
         PassingYear = "2018",
         Result = 3.2m
     },
     new Education
     {
         EducationId = 5,
         ApplicantId = 5,  // Matches ApplicantId from Applicants table
         Degree = "Diploma",
         Institution = "Institute E",
         PassingYear = "2019",
         Result = 3.0m
     },
     new Education
     {
         EducationId = 6,
         ApplicantId = 6,  // Matches ApplicantId from Applicants table
         Degree = "Bachelor's Degree",
         Institution = "University F",
         PassingYear = "2021",
         Result = 3.6m
     },
     new Education
     {
         EducationId = 7,
         ApplicantId = 7,  // Matches ApplicantId from Applicants table
         Degree = "Master's Degree",
         Institution = "University G",
         PassingYear = "2023",
         Result = 3.9m
     },
     new Education
     {
         EducationId = 8,
         ApplicantId = 8,  // Matches ApplicantId from Applicants table
         Degree = "Certificate",
         Institution = "Training Center H",
         PassingYear = "2022",
         Result = 3.8m
     },
     new Education
     {
         EducationId = 9,
         ApplicantId = 9,  // Matches ApplicantId from Applicants table
         Degree = "High School",
         Institution = "School I",
         PassingYear = "2017",
         Result = 3.1m
     },
     new Education
     {
         EducationId = 10,
         ApplicantId = 10,  // Matches ApplicantId from Applicants table
         Degree = "Bachelor's Degree",
         Institution = "University J",
         PassingYear = "2020",
         Result = 3.7m
     }
 );



            // Seed data for WorkExperience
            modelBuilder.Entity<WorkExperience>().HasData(
     new WorkExperience
     {
         WorkExperienceId = 1,
         ApplicantId = 1,  // Matches ApplicantId from Applicants table
         Company = "TechCorp",
         Position = "Software Engineer",
         Duration = "2 years"
     },
     new WorkExperience
     {
         WorkExperienceId = 2,
         ApplicantId = 2,  // Matches ApplicantId from Applicants table
         Company = "WebSolutions",
         Position = "Frontend Developer",
         Duration = "3 years"
     },
     new WorkExperience
     {
         WorkExperienceId = 3,
         ApplicantId = 3,  // Matches ApplicantId from Applicants table
         Company = "DataWorks",
         Position = "Data Scientist",
         Duration = "4 years"
     },
     new WorkExperience
     {
         WorkExperienceId = 4,
         ApplicantId = 4,  // Matches ApplicantId from Applicants table
         Company = "FinanceTech",
         Position = "Backend Developer",
         Duration = "1 year"
     },
     new WorkExperience
     {
         WorkExperienceId = 5,
         ApplicantId = 5,  // Matches ApplicantId from Applicants table
         Company = "GameStudio",
         Position = "Game Developer",
         Duration = "2 years"
     },
     new WorkExperience
     {
         WorkExperienceId = 6,
         ApplicantId = 6,  // Matches ApplicantId from Applicants table
         Company = "DevOpsInc",
         Position = "DevOps Engineer",
         Duration = "3 years"
     },
     new WorkExperience
     {
         WorkExperienceId = 7,
         ApplicantId = 7,  // Matches ApplicantId from Applicants table
         Company = "MicroServicesCo",
         Position = "Microservices Architect",
         Duration = "4 years"
     },
     new WorkExperience
     {
         WorkExperienceId = 8,
         ApplicantId = 8,  // Matches ApplicantId from Applicants table
         Company = "AppDesign",
         Position = "iOS Developer",
         Duration = "2 years"
     },
     new WorkExperience
     {
         WorkExperienceId = 9,
         ApplicantId = 9,  // Matches ApplicantId from Applicants table
         Company = "WebTech",
         Position = "Full Stack Developer",
         Duration = "3 years"
     },
     new WorkExperience
     {
         WorkExperienceId = 10,
         ApplicantId = 10,  // Matches ApplicantId from Applicants table
         Company = "EnterpriseSolutions",
         Position = "PHP Developer",
         Duration = "5 years"
     }
 );


            // Seed data for Interview
            modelBuilder.Entity<Interview>().HasData(
                new Interview
                {
                    InterviewId = 1,
                    DateTime = new DateTime(2024, 07, 01, 10, 00, 00),
                    Location = "Conference Room A",
                    Notes = "Initial screening for software engineer position.",
                    IsActive = true,
                    Interviewer = "John Smith",
                    ApplicantId = 1,
                    InterviewType = Interview.InterviewTypes.PreliminaryTest,
                    DurationMinutes = 30,
                    Feedback = "Candidate demonstrated strong technical skills.",
                    Outcome = "Pending",
                    FollowUp = "Schedule a technical interview."
                },
                new Interview
                {
                    InterviewId = 2,
                    DateTime = new DateTime(2024, 07, 02, 14, 00, 00),
                    Location = "Zoom Meeting",
                    Notes = "Technical interview with frontend developer.",
                    IsActive = true,
                    Interviewer = "Alice Johnson",
                    ApplicantId = 2,
                    InterviewType = Interview.InterviewTypes.Written,
                    DurationMinutes = 45,
                    Feedback = "Good problem-solving abilities, needs to improve on coding efficiency.",
                    Outcome = "Pending",
                    FollowUp = "Send coding challenge for further assessment."
                },
                new Interview
                {
                    InterviewId = 3,
                    DateTime = new DateTime(2024, 07, 03, 09, 00, 00),
                    Location = "Office Lobby",
                    Notes = "In-person interview for data scientist role.",
                    IsActive = true,
                    Interviewer = "Robert Brown",
                    ApplicantId = 3,
                    InterviewType = Interview.InterviewTypes.OralTest,
                    DurationMinutes = 60,
                    Feedback = "Excellent understanding of data analysis concepts.",
                    Outcome = "Hired",
                    FollowUp = "Prepare offer letter."
                },
                new Interview
                {
                    InterviewId = 4,
                    DateTime = new DateTime(2024, 07, 04, 11, 00, 00),
                    Location = "Conference Room B",
                    Notes = "Final round interview for project manager position.",
                    IsActive = true,
                    Interviewer = "Emily White",
                    ApplicantId = 4,
                    InterviewType = Interview.InterviewTypes.PreliminaryTest,
                    DurationMinutes = 40,
                    Feedback = "Strong leadership skills but lacks experience in Agile methodologies.",
                    Outcome = "Pending",
                    FollowUp = "Discuss with team regarding Agile experience."
                },
                new Interview
                {
                    InterviewId = 5,
                    DateTime = new DateTime(2024, 07, 05, 13, 00, 00),
                    Location = "Office Meeting Room",
                    Notes = "Interview for UX designer position.",
                    IsActive = true,
                    Interviewer = "Grace Clark",
                    ApplicantId = 5,
                    InterviewType = Interview.InterviewTypes.Written,
                    DurationMinutes = 50,
                    Feedback = "Good design portfolio, needs improvement in user research.",
                    Outcome = "Hired",
                    FollowUp = "Arrange onboarding session."
                },
                new Interview
                {
                    InterviewId = 6,
                    DateTime = new DateTime(2024, 07, 06, 15, 00, 00),
                    Location = "Virtual Meeting",
                    Notes = "Initial interview for business analyst role.",
                    IsActive = false,
                    Interviewer = "Henry Allen",
                    ApplicantId = 6,
                    InterviewType = Interview.InterviewTypes.OralTest,
                    DurationMinutes = 30,
                    Feedback = "Candidate has good analytical skills.",
                    Outcome = "Rejected",
                    FollowUp = "Send rejection email."
                },
                new Interview
                {
                    InterviewId = 7,
                    DateTime = new DateTime(2024, 07, 07, 10, 00, 00),
                    Location = "Conference Room C",
                    Notes = "Technical interview for systems analyst position.",
                    IsActive = true,
                    Interviewer = "Linda Gray",
                    ApplicantId = 7,
                    InterviewType = Interview.InterviewTypes.PreliminaryTest,
                    DurationMinutes = 35,
                    Feedback = "Impressive technical knowledge but weak in communication skills.",
                    Outcome = "Pending",
                    FollowUp = "Consider additional communication training."
                },
                new Interview
                {
                    InterviewId = 8,
                    DateTime = new DateTime(2024, 07, 08, 16, 00, 00),
                    Location = "Office Meeting Room",
                    Notes = "Final interview for network engineer role.",
                    IsActive = true,
                    Interviewer = "Sarah Black",
                    ApplicantId = 8,
                    InterviewType = Interview.InterviewTypes.Written,
                    DurationMinutes = 60,
                    Feedback = "Strong technical background and problem-solving skills.",
                    Outcome = "Hired",
                    FollowUp = "Prepare employment contract."
                },
                new Interview
                {
                    InterviewId = 9,
                    DateTime = new DateTime(2024, 07, 09, 11, 00, 00),
                    Location = "Zoom Meeting",
                    Notes = "Interview for cloud engineer position.",
                    IsActive = true,
                    Interviewer = "Paul Black",
                    ApplicantId = 9,
                    InterviewType = Interview.InterviewTypes.OralTest,
                    DurationMinutes = 40,
                    Feedback = "Excellent knowledge of cloud technologies, needs to work on soft skills.",
                    Outcome = "Pending",
                    FollowUp = "Arrange for soft skills training."
                },
                new Interview
                {
                    InterviewId = 10,
                    DateTime = new DateTime(2024, 07, 10, 09, 00, 00),
                    Location = "Office Conference Room",
                    Notes = "Interview for IT support specialist.",
                    IsActive = true,
                    Interviewer = "Samantha Lee",
                    ApplicantId = 10,
                    InterviewType = Interview.InterviewTypes.PreliminaryTest,
                    DurationMinutes = 30,
                    Feedback = "Good technical skills, but needs more experience in customer support.",
                    Outcome = "Hired",
                    FollowUp = "Send onboarding instructions."
                }
            );



            // Seed data for JobPosting
            modelBuilder.Entity<JobPosting>().HasData(
                new JobPosting
                {
                    JobPostingId = 1,
                    Title = "Software Engineer",
                    Description = "Develop and maintain software applications.",
                    IsInternal = false,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 08, 01),
                    ApplicationDeadline = new DateTime(2024, 08, 31),
                    StartDate = new DateTime(2024, 09, 15),
                    City = "San Francisco",
                    ContactEmail = "hr@company.com",
                    ContactPhone = "123-456-7890",
                    SalaryInformation = "Competitive salary based on experience",
                    Requirements = "Bachelor's degree in Computer Science, 2+ years of experience.",
                    JobType = "Full-time",
                    ExperienceRequired = "2 years",
                    EducationRequired = "Bachelor's degree",
                    SkillsRequired = "C#, .NET, SQL",
                    BenefitsOffered = "Healthcare, 401(k), Paid time off",
                    WorkSchedule = "Monday to Friday, 9 AM to 5 PM",
                    IsRemoteWork = false
                },
                new JobPosting
                {
                    JobPostingId = 2,
                    Title = "UX Designer",
                    Description = "Design user-friendly interfaces and experiences.",
                    IsInternal = true,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 08, 05),
                    ApplicationDeadline = new DateTime(2024, 09, 05),
                    StartDate = new DateTime(2024, 10, 01),
                    City = "New York",
                    ContactEmail = "design@company.com",
                    ContactPhone = "987-654-3210",
                    SalaryInformation = "Negotiable based on experience",
                    Requirements = "3+ years of UX/UI design experience.",
                    JobType = "Part-time",
                    ExperienceRequired = "3 years",
                    EducationRequired = "Associate's degree or higher",
                    SkillsRequired = "Sketch, Figma, Adobe XD",
                    BenefitsOffered = "Healthcare, Flexible working hours",
                    WorkSchedule = "Flexible hours",
                    IsRemoteWork = true
                },
                new JobPosting
                {
                    JobPostingId = 3,
                    Title = "Project Manager",
                    Description = "Manage project timelines, budgets, and team coordination.",
                    IsInternal = false,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 08, 10),
                    ApplicationDeadline = new DateTime(2024, 09, 10),
                    StartDate = new DateTime(2024, 09, 20),
                    City = "Chicago",
                    ContactEmail = "pm@company.com",
                    ContactPhone = "555-123-4567",
                    SalaryInformation = "Up to $100,000 per year",
                    Requirements = "PMP certification, 5+ years of project management experience.",
                    JobType = "Full-time",
                    ExperienceRequired = "5 years",
                    EducationRequired = "Bachelor's degree",
                    SkillsRequired = "Project management, Budgeting, Scheduling",
                    BenefitsOffered = "Healthcare, Retirement plan, Paid vacation",
                    WorkSchedule = "Monday to Friday, 8 AM to 4 PM",
                    IsRemoteWork = false
                },
                new JobPosting
                {
                    JobPostingId = 4,
                    Title = "Data Analyst",
                    Description = "Analyze data and generate reports to support business decisions.",
                    IsInternal = false,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 08, 15),
                    ApplicationDeadline = new DateTime(2024, 09, 15),
                    StartDate = new DateTime(2024, 10, 01),
                    City = "Los Angeles",
                    ContactEmail = "data@company.com",
                    ContactPhone = "321-654-9870",
                    SalaryInformation = "Competitive salary, based on experience",
                    Requirements = "2+ years of data analysis experience, proficiency in SQL.",
                    JobType = "Contract",
                    ExperienceRequired = "2 years",
                    EducationRequired = "Bachelor's degree in a related field",
                    SkillsRequired = "SQL, Excel, Data visualization",
                    BenefitsOffered = "Healthcare, Paid sick leave",
                    WorkSchedule = "Monday to Friday, 9 AM to 6 PM",
                    IsRemoteWork = true
                },
                new JobPosting
                {
                    JobPostingId = 5,
                    Title = "Marketing Coordinator",
                    Description = "Coordinate marketing campaigns and events.",
                    IsInternal = true,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 08, 20),
                    ApplicationDeadline = new DateTime(2024, 09, 20),
                    StartDate = new DateTime(2024, 10, 10),
                    City = "Boston",
                    ContactEmail = "marketing@company.com",
                    ContactPhone = "654-321-0987",
                    SalaryInformation = "Base salary + performance bonuses",
                    Requirements = "1+ years of marketing experience.",
                    JobType = "Full-time",
                    ExperienceRequired = "1 year",
                    EducationRequired = "Bachelor's degree in Marketing or related field",
                    SkillsRequired = "Marketing strategy, Event planning, Social media",
                    BenefitsOffered = "Healthcare, 401(k), Paid time off",
                    WorkSchedule = "Monday to Friday, 8 AM to 5 PM",
                    IsRemoteWork = false
                },
                new JobPosting
                {
                    JobPostingId = 6,
                    Title = "Customer Support Specialist",
                    Description = "Provide customer support and resolve customer issues.",
                    IsInternal = false,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 08, 25),
                    ApplicationDeadline = new DateTime(2024, 09, 25),
                    StartDate = new DateTime(2024, 10, 15),
                    City = "Seattle",
                    ContactEmail = "support@company.com",
                    ContactPhone = "456-789-0123",
                    SalaryInformation = "Hourly rate + benefits",
                    Requirements = "Excellent communication skills, 1+ years of customer service experience.",
                    JobType = "Part-time",
                    ExperienceRequired = "1 year",
                    EducationRequired = "High school diploma",
                    SkillsRequired = "Customer service, Problem-solving, Communication",
                    BenefitsOffered = "Healthcare, Paid time off",
                    WorkSchedule = "Flexible hours",
                    IsRemoteWork = true
                },
                new JobPosting
                {
                    JobPostingId = 7,
                    Title = "Graphic Designer",
                    Description = "Design marketing materials and brand assets.",
                    IsInternal = true,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 09, 01),
                    ApplicationDeadline = new DateTime(2024, 10, 01),
                    StartDate = new DateTime(2024, 11, 01),
                    City = "San Diego",
                    ContactEmail = "design@company.com",
                    ContactPhone = "789-012-3456",
                    SalaryInformation = "Competitive salary based on experience",
                    Requirements = "2+ years of graphic design experience, portfolio required.",
                    JobType = "Full-time",
                    ExperienceRequired = "2 years",
                    EducationRequired = "Bachelor's degree in Design or related field",
                    SkillsRequired = "Adobe Creative Suite, Graphic design, Creativity",
                    BenefitsOffered = "Healthcare, 401(k), Paid time off",
                    WorkSchedule = "Monday to Friday, 9 AM to 5 PM",
                    IsRemoteWork = false
                },
                new JobPosting
                {
                    JobPostingId = 8,
                    Title = "Software Tester",
                    Description = "Test software applications to ensure quality and performance.",
                    IsInternal = false,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 09, 05),
                    ApplicationDeadline = new DateTime(2024, 10, 05),
                    StartDate = new DateTime(2024, 11, 01),
                    City = "Austin",
                    ContactEmail = "testing@company.com",
                    ContactPhone = "012-345-6789",
                    SalaryInformation = "Up to $80,000 per year",
                    Requirements = "1+ years of software testing experience.",
                    JobType = "Contract",
                    ExperienceRequired = "1 year",
                    EducationRequired = "Bachelor's degree in Computer Science",
                    SkillsRequired = "Testing tools, Attention to detail, Problem-solving",
                    BenefitsOffered = "Healthcare, Paid time off",
                    WorkSchedule = "Monday to Friday, 10 AM to 6 PM",
                    IsRemoteWork = true
                },
                new JobPosting
                {
                    JobPostingId = 9,
                    Title = "HR Specialist",
                    Description = "Manage HR functions and employee relations.",
                    IsInternal = true,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 09, 10),
                    ApplicationDeadline = new DateTime(2024, 10, 10),
                    StartDate = new DateTime(2024, 11, 15),
                    City = "Philadelphia",
                    ContactEmail = "hr@company.com",
                    ContactPhone = "345-678-9012",
                    SalaryInformation = "Negotiable based on experience",
                    Requirements = "3+ years of HR experience, strong interpersonal skills.",
                    JobType = "Full-time",
                    ExperienceRequired = "3 years",
                    EducationRequired = "Bachelor's degree in Human Resources or related field",
                    SkillsRequired = "HR management, Employee relations, Recruitment",
                    BenefitsOffered = "Healthcare, 401(k), Paid vacation",
                    WorkSchedule = "Monday to Friday, 8 AM to 5 PM",
                    IsRemoteWork = false
                },
                new JobPosting
                {
                    JobPostingId = 10,
                    Title = "Content Writer",
                    Description = "Write and edit content for various platforms.",
                    IsInternal = false,
                    IsActive = true,
                    PostingDate = new DateTime(2024, 09, 15),
                    ApplicationDeadline = new DateTime(2024, 10, 15),
                    StartDate = new DateTime(2024, 11, 01),
                    City = "Denver",
                    ContactEmail = "content@company.com",
                    ContactPhone = "456-789-1234",
                    SalaryInformation = "Competitive salary with performance bonuses",
                    Requirements = "2+ years of content writing experience, strong writing skills.",
                    JobType = "Part-time",
                    ExperienceRequired = "2 years",
                    EducationRequired = "Bachelor's degree in English or related field",
                    SkillsRequired = "Content writing, SEO, Editing",
                    BenefitsOffered = "Healthcare, Flexible working hours",
                    WorkSchedule = "Flexible hours",
                    IsRemoteWork = true
                }
            );

            #endregion SeedDataForRecruitmentManagement

            #region SeedDataForPerformenceManagement
            //seed data for DevelopmentPlan
            modelBuilder.Entity<DevelopmentPlan>().HasData(
    new DevelopmentPlan
    {
        DevelopmentPlanId = 1,
        EmployeeId = 1,
        Description = "Improve communication skills.",
        TargetCompletionDate = new DateTime(2024, 12, 31),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Pending,
        Progress = 20,
        IsActive = true,
        Feedback = "Needs more practice in public speaking.",
        Resources = "Online communication course, public speaking workshops.",
        CompletionDate = null
    },
    new DevelopmentPlan
    {
        DevelopmentPlanId = 2,
        EmployeeId = 2,
        Description = "Gain advanced skills in C#.",
        TargetCompletionDate = new DateTime(2024, 11, 30),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Approved,
        Progress = 40,
        IsActive = true,
        Feedback = "Excellent progress so far.",
        Resources = "Advanced C# course, mentorship.",
        CompletionDate = null
    },
    new DevelopmentPlan
    {
        DevelopmentPlanId = 3,
        EmployeeId = 3,
        Description = "Enhance project management skills.",
        TargetCompletionDate = new DateTime(2024, 10, 31),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Pending,
        Progress = 30,
        IsActive = true,
        Feedback = "Needs more focus on risk management.",
        Resources = "PMI certification course, project simulations.",
        CompletionDate = null
    },
    new DevelopmentPlan
    {
        DevelopmentPlanId = 4,
        EmployeeId = 4,
        Description = "Improve time management.",
        TargetCompletionDate = new DateTime(2024, 09, 30),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Rejected,
        Progress = 10,
        IsActive = false,
        Feedback = "Plan rejected due to insufficient details.",
        Resources = "Time management workshops, books.",
        CompletionDate = null
    },
    new DevelopmentPlan
    {
        DevelopmentPlanId = 5,
        EmployeeId = 5,
        Description = "Develop leadership skills.",
        TargetCompletionDate = new DateTime(2024, 12, 31),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Pending,
        Progress = 50,
        IsActive = true,
        Feedback = "Showing promise, continue with current plan.",
        Resources = "Leadership seminars, mentoring.",
        CompletionDate = null
    },
    new DevelopmentPlan
    {
        DevelopmentPlanId = 6,
        EmployeeId = 6,
        Description = "Learn new database management techniques.",
        TargetCompletionDate = new DateTime(2024, 12, 01),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Approved,
        Progress = 60,
        IsActive = true,
        Feedback = "Great progress in database design.",
        Resources = "SQL workshops, advanced database books.",
        CompletionDate = null
    },
    new DevelopmentPlan
    {
        DevelopmentPlanId = 7,
        EmployeeId = 7,
        Description = "Master cloud computing.",
        TargetCompletionDate = new DateTime(2024, 08, 30),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Approved,
        Progress = 70,
        IsActive = true,
        Feedback = "On track for certification.",
        Resources = "Cloud certifications, online courses.",
        CompletionDate = null
    },
    new DevelopmentPlan
    {
        DevelopmentPlanId = 8,
        EmployeeId = 8,
        Description = "Increase proficiency in Angular.",
        TargetCompletionDate = new DateTime(2024, 07, 31),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Approved,
        Progress = 80,
        IsActive = true,
        Feedback = "Nearly complete, great work!",
        Resources = "Angular documentation, online courses.",
        CompletionDate = null
    },
    new DevelopmentPlan
    {
        DevelopmentPlanId = 9,
        EmployeeId = 9,
        Description = "Improve technical writing skills.",
        TargetCompletionDate = new DateTime(2024, 06, 30),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Pending,
        Progress = 20,
        IsActive = true,
        Feedback = "Needs more practice.",
        Resources = "Technical writing courses, guides.",
        CompletionDate = null
    },
    new DevelopmentPlan
    {
        DevelopmentPlanId = 10,
        EmployeeId = 10,
        Description = "Gain proficiency in cybersecurity.",
        TargetCompletionDate = new DateTime(2024, 05, 31),
        DevelopmentPlanStatus = DevelopmentPlan.DevelopmentPlanStatuses.Approved,
        Progress = 90,
        IsActive = true,
        Feedback = "Almost complete, keep up the good work!",
        Resources = "Cybersecurity certifications, online courses.",
        CompletionDate = null
    }
);

            //Seed Data For Goal 
            modelBuilder.Entity<Goal>().HasData(
    new Goal
    {
        GoalId = 1,
        Title = "Complete Project Alpha",
        Description = "Finish all tasks related to Project Alpha by Q3.",
        StartDate = new DateTime(2024, 01, 01),
        EndDate = new DateTime(2024, 09, 30),
        EmployeeId = 1,
        GoalStatus = Goal.GoalStatuses.Pending,
        Progress = 40,
        IsActive = true,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "Manager",
        CompletionDate = null,
        AssignedByUserId = 1,
        Comments = "On track for completion."
    },
    new Goal
    {
        GoalId = 2,
        Title = "Increase Sales by 20%",
        Description = "Boost sales by 20% by end of the year.",
        StartDate = new DateTime(2024, 01, 01),
        EndDate = new DateTime(2024, 12, 31),
        EmployeeId = 2,
        GoalStatus = Goal.GoalStatuses.Approved,
        Progress = 50,
        IsActive = true,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "Sales Director",
        CompletionDate = null,
        AssignedByUserId = 2,
        Comments = "Sales are improving steadily."
    },
    new Goal
    {
        GoalId = 3,
        Title = "Launch New Marketing Campaign",
        Description = "Introduce a new marketing campaign to increase brand awareness.",
        StartDate = new DateTime(2024, 02, 01),
        EndDate = new DateTime(2024, 07, 31),
        EmployeeId = 3,
        GoalStatus = Goal.GoalStatuses.Pending,
        Progress = 30,
        IsActive = true,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "Marketing Head",
        CompletionDate = null,
        AssignedByUserId = 3,
        Comments = "Working on campaign materials."
    },
    new Goal
    {
        GoalId = 4,
        Title = "Enhance Customer Support",
        Description = "Improve customer support response time by 50%.",
        StartDate = new DateTime(2024, 03, 01),
        EndDate = new DateTime(2024, 09, 30),
        EmployeeId = 4,
        GoalStatus = Goal.GoalStatuses.Rejected,
        Progress = 10,
        IsActive = false,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "Support Manager",
        CompletionDate = null,
        AssignedByUserId = 4,
        Comments = "Plan needs more details."
    },
    new Goal
    {
        GoalId = 5,
        Title = "Develop New Product Feature",
        Description = "Create and implement a new feature for the flagship product.",
        StartDate = new DateTime(2024, 04, 01),
        EndDate = new DateTime(2024, 12, 31),
        EmployeeId = 5,
        GoalStatus = Goal.GoalStatuses.Approved,
        Progress = 60,
        IsActive = true,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "Product Manager",
        CompletionDate = null,
        AssignedByUserId = 5,
        Comments = "Feature development is going well."
    },
    new Goal
    {
        GoalId = 6,
        Title = "Reduce Operational Costs",
        Description = "Cut operational costs by 15% by Q4.",
        StartDate = new DateTime(2024, 01, 01),
        EndDate = new DateTime(2024, 10, 31),
        EmployeeId = 6,
        GoalStatus = Goal.GoalStatuses.Pending,
        Progress = 20,
        IsActive = true,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "Operations Head",
        CompletionDate = null,
        AssignedByUserId = 6,
        Comments = "Identifying areas to reduce costs."
    },
    new Goal
    {
        GoalId = 7,
        Title = "Improve Team Collaboration",
        Description = "Enhance collaboration across departments.",
        StartDate = new DateTime(2024, 02, 01),
        EndDate = new DateTime(2024, 08, 31),
        EmployeeId = 7,
        GoalStatus = Goal.GoalStatuses.Approved,
        Progress = 50,
        IsActive = true,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "HR Manager",
        CompletionDate = null,
        AssignedByUserId = 7,
        Comments = "Collaboration tools have been introduced."
    },
    new Goal
    {
        GoalId = 8,
        Title = "Optimize Supply Chain",
        Description = "Streamline the supply chain to reduce delays.",
        StartDate = new DateTime(2024, 01, 01),
        EndDate = new DateTime(2024, 09, 30),
        EmployeeId = 8,
        GoalStatus = Goal.GoalStatuses.Approved,
        Progress = 60,
        IsActive = true,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "Supply Chain Manager",
        CompletionDate = null,
        AssignedByUserId = 8,
        Comments = "Supply chain optimization is in progress."
    },
    new Goal
    {
        GoalId = 9,
        Title = "Implement New CRM System",
        Description = "Introduce a new CRM system to improve customer management.",
        StartDate = new DateTime(2024, 03, 01),
        EndDate = new DateTime(2024, 12, 31),
        EmployeeId = 9,
        GoalStatus = Goal.GoalStatuses.Pending,
        Progress = 30,
        IsActive = true,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "IT Manager",
        CompletionDate = null,
        AssignedByUserId = 9,
        Comments = "System is under testing."
    },
    new Goal
    {
        GoalId = 10,
        Title = "Enhance Data Security",
        Description = "Implement new data security measures to protect company assets.",
        StartDate = new DateTime(2024, 01, 01),
        EndDate = new DateTime(2024, 06, 30),
        EmployeeId = 10,
        GoalStatus = Goal.GoalStatuses.Approved,
        Progress = 70,
        IsActive = true,
        LastUpdatedDate = DateTime.Now,
        UpdatedBy = "Security Officer",
        CompletionDate = null,
        AssignedByUserId = 10,
        Comments = "Security protocols are being updated."
    }
);

            //seed data for PerformenceReport 
            modelBuilder.Entity<PerformanceReport>().HasData(
    new PerformanceReport
    {
        PerformanceReportId = 1,
        EmployeeId = 1,
        EvaluatorId = 2,
        EvaluationDate = new DateTime(2024, 04, 15),
        PerformanceScore = 85,
        GoalsMet = "5 out of 7",
        Strengths = "Excellent problem-solving skills.",
        AreasForImprovement = "Needs to improve time management.",
        Achievements = "Led successful project delivery.",
        DevelopmentPlan = "Focus on time management training.",
        Comments = "Great performance, keep up the good work.",
        OverallRating = "Above Average",
        ReviewPeriodStart = new DateTime(2023, 10, 01),
        ReviewPeriodEnd = new DateTime(2024, 03, 31),
        Status = "Completed",
        ActionItems = "Set up a follow-up meeting in 3 months."
    },
    new PerformanceReport
    {
        PerformanceReportId = 2,
        EmployeeId = 3,
        EvaluatorId = 4,
        EvaluationDate = new DateTime(2024, 05, 20),
        PerformanceScore = 75,
        GoalsMet = "4 out of 6",
        Strengths = "Strong technical knowledge.",
        AreasForImprovement = "Needs better communication skills.",
        Achievements = "Implemented new system architecture.",
        DevelopmentPlan = "Enroll in communication workshops.",
        Comments = "Good overall performance, with room for improvement.",
        OverallRating = "Average",
        ReviewPeriodStart = new DateTime(2023, 11, 01),
        ReviewPeriodEnd = new DateTime(2024, 04, 30),
        Status = "Completed",
        ActionItems = "Review progress in the next quarter."
    },
    new PerformanceReport
    {
        PerformanceReportId = 3,
        EmployeeId = 5,
        EvaluatorId = 6,
        EvaluationDate = new DateTime(2024, 03, 10),
        PerformanceScore = 90,
        GoalsMet = "6 out of 7",
        Strengths = "Excellent leadership and team management.",
        AreasForImprovement = "Focus on strategic planning.",
        Achievements = "Successfully launched a new product line.",
        DevelopmentPlan = "Attend leadership and strategy seminars.",
        Comments = "Outstanding performance, well done.",
        OverallRating = "Excellent",
        ReviewPeriodStart = new DateTime(2023, 09, 01),
        ReviewPeriodEnd = new DateTime(2024, 02, 28),
        Status = "Completed",
        ActionItems = "Continue with leadership training."
    },
    new PerformanceReport
    {
        PerformanceReportId = 4,
        EmployeeId = 7,
        EvaluatorId = 8,
        EvaluationDate = new DateTime(2024, 06, 25),
        PerformanceScore = 80,
        GoalsMet = "5 out of 7",
        Strengths = "Strong analytical skills.",
        AreasForImprovement = "Improve decision-making speed.",
        Achievements = "Analyzed and optimized business processes.",
        DevelopmentPlan = "Participate in decision-making workshops.",
        Comments = "Solid performance, needs slight improvements.",
        OverallRating = "Above Average",
        ReviewPeriodStart = new DateTime(2023, 12, 01),
        ReviewPeriodEnd = new DateTime(2024, 05, 31),
        Status = "Completed",
        ActionItems = "Schedule a check-in meeting next quarter."
    },
    new PerformanceReport
    {
        PerformanceReportId = 5,
        EmployeeId = 9,
        EvaluatorId = 10,
        EvaluationDate = new DateTime(2024, 02, 05),
        PerformanceScore = 70,
        GoalsMet = "3 out of 5",
        Strengths = "Good team collaboration.",
        AreasForImprovement = "Enhance technical skills.",
        Achievements = "Supported multiple successful projects.",
        DevelopmentPlan = "Focus on technical certifications.",
        Comments = "Needs improvement in technical aspects.",
        OverallRating = "Average",
        ReviewPeriodStart = new DateTime(2023, 08, 01),
        ReviewPeriodEnd = new DateTime(2024, 01, 31),
        Status = "Completed",
        ActionItems = "Review progress in the next performance cycle."
    },
    new PerformanceReport
    {
        PerformanceReportId = 6,
        EmployeeId = 2,
        EvaluatorId = 3,
        EvaluationDate = new DateTime(2024, 04, 10),
        PerformanceScore = 85,
        GoalsMet = "4 out of 5",
        Strengths = "Great attention to detail.",
        AreasForImprovement = "Needs to improve delegation skills.",
        Achievements = "Delivered complex project on time.",
        DevelopmentPlan = "Attend workshops on delegation and leadership.",
        Comments = "Good performance, with potential for growth.",
        OverallRating = "Above Average",
        ReviewPeriodStart = new DateTime(2023, 09, 15),
        ReviewPeriodEnd = new DateTime(2024, 02, 29),
        Status = "Completed",
        ActionItems = "Schedule a leadership training session."
    },
    new PerformanceReport
    {
        PerformanceReportId = 7,
        EmployeeId = 4,
        EvaluatorId = 5,
        EvaluationDate = new DateTime(2024, 03, 20),
        PerformanceScore = 80,
        GoalsMet = "5 out of 6",
        Strengths = "Strong client relationship management.",
        AreasForImprovement = "Enhance negotiation skills.",
        Achievements = "Secured major client deals.",
        DevelopmentPlan = "Participate in negotiation training.",
        Comments = "Solid performance with room for growth.",
        OverallRating = "Above Average",
        ReviewPeriodStart = new DateTime(2023, 11, 01),
        ReviewPeriodEnd = new DateTime(2024, 03, 31),
        Status = "Completed",
        ActionItems = "Follow up on client feedback."
    },
    new PerformanceReport
    {
        PerformanceReportId = 8,
        EmployeeId = 6,
        EvaluatorId = 7,
        EvaluationDate = new DateTime(2024, 05, 15),
        PerformanceScore = 75,
        GoalsMet = "4 out of 5",
        Strengths = "Effective team player.",
        AreasForImprovement = "Improve technical documentation skills.",
        Achievements = "Contributed significantly to team success.",
        DevelopmentPlan = "Focus on technical writing courses.",
        Comments = "Good performance, with minor improvements needed.",
        OverallRating = "Average",
        ReviewPeriodStart = new DateTime(2023, 10, 01),
        ReviewPeriodEnd = new DateTime(2024, 03, 31),
        Status = "Completed",
        ActionItems = "Schedule a writing workshop."
    },
    new PerformanceReport
    {
        PerformanceReportId = 9,
        EmployeeId = 7,
        EvaluatorId = 8,
        EvaluationDate = new DateTime(2024, 05, 15),
        PerformanceScore = 85,
        GoalsMet = "4 out of 5",
        Strengths = "Effective team player.",
        AreasForImprovement = "Improve technical documentation skills.",
        Achievements = "Contributed significantly to team success.",
        DevelopmentPlan = "Focus on technical writing courses.",
        Comments = "Good performance, with minor improvements needed.",
        OverallRating = "Average",
        ReviewPeriodStart = new DateTime(2023, 10, 01),
        ReviewPeriodEnd = new DateTime(2024, 03, 31),
        Status = "Completed",
        ActionItems = "Schedule a writing workshop."
    },
    new PerformanceReport
    {
        PerformanceReportId = 10,
        EmployeeId = 8,
        EvaluatorId = 9,
        EvaluationDate = new DateTime(2024, 05, 15),
        PerformanceScore = 90,
        GoalsMet = "4 out of 5",
        Strengths = "Effective team player.",
        AreasForImprovement = "Improve technical documentation skills.",
        Achievements = "Contributed significantly to team success.",
        DevelopmentPlan = "Focus on technical writing courses.",
        Comments = "Good performance, with minor improvements needed.",
        OverallRating = "Average",
        ReviewPeriodStart = new DateTime(2023, 10, 01),
        ReviewPeriodEnd = new DateTime(2024, 03, 31),
        Status = "Completed",
        ActionItems = "Schedule a writing workshop."
    }

    );
            // seed data for performence review
            modelBuilder.Entity<PerformanceReview>().HasData(
       new PerformanceReview { PerformanceReviewId = 1, EmployeeId = 1, ReviewerId = 1, Feedback = "Great job overall, keep up the good work.", PerformanceRating = 5, Comments = "Exceptional performance", ReviewDate = DateTime.Now, ReviewType = "Annual" },
       new PerformanceReview { PerformanceReviewId = 2, EmployeeId = 2, ReviewerId = 2, Feedback = "Good progress but needs improvement in communication.", PerformanceRating = 4, Comments = "Solid performance", ReviewDate = DateTime.Now, ReviewType = "Quarterly" },
       new PerformanceReview { PerformanceReviewId = 3, EmployeeId = 3, ReviewerId = 3, Feedback = "Requires more focus on client interactions.", PerformanceRating = 3, Comments = "Satisfactory performance", ReviewDate = DateTime.Now, ReviewType = "Annual" },
       new PerformanceReview { PerformanceReviewId = 4, EmployeeId = 4, ReviewerId = 4, Feedback = "Excellent leadership skills demonstrated.", PerformanceRating = 5, Comments = "Outstanding", ReviewDate = DateTime.Now, ReviewType = "Quarterly" },
       new PerformanceReview { PerformanceReviewId = 5, EmployeeId = 5, ReviewerId = 5, Feedback = "Good analytical skills, needs improvement in client relations.", PerformanceRating = 4, Comments = "Good effort", ReviewDate = DateTime.Now, ReviewType = "Annual" },
       new PerformanceReview { PerformanceReviewId = 6, EmployeeId = 6, ReviewerId = 6, Feedback = "Strong teamwork but needs better project management.", PerformanceRating = 4, Comments = "Good teamwork", ReviewDate = DateTime.Now, ReviewType = "Quarterly" },
       new PerformanceReview { PerformanceReviewId = 7, EmployeeId = 7, ReviewerId = 7, Feedback = "Creative thinking is a strength, work on organizational skills.", PerformanceRating = 3, Comments = "Needs improvement", ReviewDate = DateTime.Now, ReviewType = "Annual" },
       new PerformanceReview { PerformanceReviewId = 8, EmployeeId = 8, ReviewerId = 8, Feedback = "Excellent technical expertise, communication skills need work.", PerformanceRating = 5, Comments = "Very strong performance", ReviewDate = DateTime.Now, ReviewType = "Quarterly" },
       new PerformanceReview { PerformanceReviewId = 9, ReviewerId = 9, EmployeeId = 9, Feedback = "Dependable employee, needs improvement in time management.", PerformanceRating = 3, Comments = "Satisfactory", ReviewDate = DateTime.Now, ReviewType = "Annual" },
       new PerformanceReview { PerformanceReviewId = 10, EmployeeId = 10, ReviewerId = 10, Feedback = "Great attention to detail, work on team collaboration.", PerformanceRating = 4, Comments = "Good performance", ReviewDate = DateTime.Now, ReviewType = "Quarterly" }
   );
            #endregion SeedDataForPerformenceManagement

            #region SeedDataForPayrollMangement

            modelBuilder.Entity<PayrollCalculation>().HasData(
    new PayrollCalculation { PayrollCalcuationId = 1, EmployeeId = 1, BasicSalary = 50000m, HouseRent = 10000m, MedicalAllowence = 5000m, ConveyanceAllowence = 3000m, OtherAllowence = 2000m },
    new PayrollCalculation { PayrollCalcuationId = 2, EmployeeId = 2, BasicSalary = 45000m, HouseRent = 9000m, MedicalAllowence = 4500m, ConveyanceAllowence = 2500m, OtherAllowence = 1500m },
    new PayrollCalculation { PayrollCalcuationId = 3, EmployeeId = 3, BasicSalary = 47000m, HouseRent = 9400m, MedicalAllowence = 4700m, ConveyanceAllowence = 2700m, OtherAllowence = 1700m },
    new PayrollCalculation { PayrollCalcuationId = 4, EmployeeId = 4, BasicSalary = 55000m, HouseRent = 11000m, MedicalAllowence = 5500m, ConveyanceAllowence = 3500m, OtherAllowence = 2500m },
    new PayrollCalculation { PayrollCalcuationId = 5, EmployeeId = 5, BasicSalary = 48000m, HouseRent = 9600m, MedicalAllowence = 4800m, ConveyanceAllowence = 2800m, OtherAllowence = 1800m },
    new PayrollCalculation { PayrollCalcuationId = 6, EmployeeId = 6, BasicSalary = 51000m, HouseRent = 10200m, MedicalAllowence = 5100m, ConveyanceAllowence = 3100m, OtherAllowence = 2100m },
    new PayrollCalculation { PayrollCalcuationId = 7, EmployeeId = 7, BasicSalary = 49000m, HouseRent = 9800m, MedicalAllowence = 4900m, ConveyanceAllowence = 2900m, OtherAllowence = 1900m },
    new PayrollCalculation { PayrollCalcuationId = 8, EmployeeId = 8, BasicSalary = 53000m, HouseRent = 10600m, MedicalAllowence = 5300m, ConveyanceAllowence = 3300m, OtherAllowence = 2300m },
    new PayrollCalculation { PayrollCalcuationId = 9, EmployeeId = 9, BasicSalary = 56000m, HouseRent = 11200m, MedicalAllowence = 5600m, ConveyanceAllowence = 3600m, OtherAllowence = 2600m },
    new PayrollCalculation { PayrollCalcuationId = 10, EmployeeId = 10, BasicSalary = 46000m, HouseRent = 9200m, MedicalAllowence = 4600m, ConveyanceAllowence = 2600m, OtherAllowence = 1600m }
    );


   
            #endregion SeedDataForPayrollMangement

            //modelBuilder.Entity<Applicant>(entity =>
            //{
            //    // Configuring the Status enum as a string in the database
            //    entity.Property(e => e.Status)
            //          .HasConversion<string>();

            //    // Configure Applicant - Education relationship
            //    modelBuilder.Entity<Education>()
            //        .HasOne(e => e.Applicant)
            //        .WithMany(a => a.Educations)
            //        .HasForeignKey(e => e.ApplicantId)
            //        .OnDelete(DeleteBehavior.Cascade);

            //    // Configure Applicant - WorkExperience relationship
            //    modelBuilder.Entity<WorkExperience>()
            //        .HasOne(w => w.Applicant)
            //        .WithMany(a => a.WorkExperiences)
            //        .HasForeignKey(w => w.ApplicantId)
            //        .OnDelete(DeleteBehavior.Cascade);
            //});



            base.OnModelCreating(modelBuilder);
        }
        #endregion Seed




    }
}
