using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL
{
    public class FanushDbContext : DbContext
    {
        public FanushDbContext(DbContextOptions<FanushDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<EmployeeLifecycle> EmployeeLifecycles { get; set; }
        public DbSet<EmployeeDataImportExport> EmployeeDataImportExports { get; set; }

        #region Seed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for JobTitles
            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle { JobTitleId = 1, JobTitleName= "Software Engineer", IsActive = true },
                new JobTitle { JobTitleId = 2, JobTitleName= "HR Manager", IsActive = true },
                new JobTitle { JobTitleId = 3, JobTitleName= "Quality Assurance Analyst", IsActive = true },
                new JobTitle { JobTitleId = 4, JobTitleName= "Marketing Specialist", IsActive = true },
                new JobTitle { JobTitleId = 5, JobTitleName= "Finance Manager", IsActive = true },
                new JobTitle { JobTitleId = 6, JobTitleName= "Operations Coordinator", IsActive = true },
                new JobTitle { JobTitleId = 7, JobTitleName= "IT Support Specialist", IsActive = true },
                new JobTitle { JobTitleId = 8, JobTitleName= "Sales Representative", IsActive = true },
                new JobTitle { JobTitleId = 9, JobTitleName= "Customer Service Representative", IsActive = true },
                new JobTitle { JobTitleId = 10,JobTitleName = "Project Manager", IsActive = true }
            );

            // Seed data for Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "Engineering", IsActive = true },
                new Department { DepartmentId = 2, DepartmentName= "Human Resources", IsActive = true },
                new Department { DepartmentId = 3, DepartmentName= "Marketing", IsActive = true },
                new Department { DepartmentId = 4, DepartmentName= "Finance", IsActive = true },
                new Department { DepartmentId = 5, DepartmentName= "Operations", IsActive = true },
                new Department { DepartmentId = 6, DepartmentName= "IT", IsActive = true },
                new Department { DepartmentId = 7, DepartmentName= "Sales", IsActive = true },
                new Department { DepartmentId = 8, DepartmentName= "Customer Service", IsActive = true },
                new Department { DepartmentId = 9, DepartmentName= "Research & Development", IsActive = true },
                new Department { DepartmentId = 10, DepartmentName = "Legal", IsActive = true }
            );

            // Seed data for Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, EmployeeName = "Joshim Bro", ContactNumber = "1234567890", Email = "Joshim@mail.com", DateOfBirth = new DateTime(1990, 1, 1), EmergencyContact = "9876543210", Gender = "Male", DateJoined = new DateTime(2010, 1, 1), DepartmentId = 1, JobTitleId = 1,  IsActive = true },
                new Employee { EmployeeId = 2, EmployeeName= "Sansa", ContactNumber = "9876543210", Email = "Sansa@example.com", DateOfBirth = new DateTime(1985, 5, 10), EmergencyContact = "1234567890", Gender = "Female", DateJoined = new DateTime(2015, 8, 15), DepartmentId = 2, JobTitleId = 2,  IsActive = true },
                new Employee { EmployeeId = 3, EmployeeName= "Michael Johnson", ContactNumber = "5555555555", Email = "michael.johnson@example.com", DateOfBirth = new DateTime(1982, 9, 20), EmergencyContact = "6666666666", Gender = "Male", DateJoined = new DateTime(2008, 3, 5), DepartmentId = 3, JobTitleId = 3,  IsActive = true },
                new Employee { EmployeeId = 4, EmployeeName= "Emily Brown", ContactNumber = "4444444444", Email = "emily.brown@example.com", DateOfBirth = new DateTime(1993, 12, 15), EmergencyContact = "3333333333", Gender = "Female", DateJoined = new DateTime(2019, 11, 12), DepartmentId = 4, JobTitleId = 4,  IsActive = true },
                new Employee { EmployeeId = 5, EmployeeName= "David Wilson", ContactNumber = "7777777777", Email = "david.wilson@example.com", DateOfBirth = new DateTime(1978, 8, 25), EmergencyContact = "8888888888", Gender = "Male", DateJoined = new DateTime(2012, 6, 30), DepartmentId = 5, JobTitleId = 5, IsActive = true },
                new Employee { EmployeeId = 6, EmployeeName= "Sophia Martinez", ContactNumber = "2222222222", Email = "sophia.martinez@example.com", DateOfBirth = new DateTime(1989, 4, 5), EmergencyContact = "9999999999", Gender = "Female", DateJoined = new DateTime(2016, 10, 20), DepartmentId = 6, JobTitleId = 6, IsActive = true },
                new Employee { EmployeeId = 7, EmployeeName= "Daniel Taylor", ContactNumber = "6666666666", Email = "daniel.taylor@example.com", DateOfBirth = new DateTime(1980, 3, 10), EmergencyContact = "1111111111", Gender = "Male", DateJoined = new DateTime(2005, 7, 18), DepartmentId = 7, JobTitleId = 7, IsActive = true },
                new Employee { EmployeeId = 8, EmployeeName= "Olivia Anderson", ContactNumber = "9999999999", Email = "olivia.anderson@example.com", DateOfBirth = new DateTime(1995, 6, 28), EmergencyContact = "7777777777", Gender = "Female", DateJoined = new DateTime(2020, 4, 22), DepartmentId = 8, JobTitleId = 8, IsActive = true },
                new Employee { EmployeeId = 9, EmployeeName= "Ethan Thomas", ContactNumber = "3333333333", Email = "ethan.thomas@example.com", DateOfBirth = new DateTime(1987, 11, 8), EmergencyContact = "5555555555", Gender = "Male", DateJoined = new DateTime(2018, 9, 3), DepartmentId = 9, JobTitleId = 9, IsActive = true },
                new Employee { EmployeeId = 10, EmployeeName = "Ava White", ContactNumber = "8888888888", Email = "ava.white@example.com", DateOfBirth = new DateTime(1991, 2, 18), EmergencyContact = "4444444444", Gender = "Female", DateJoined = new DateTime(2013, 12, 10), DepartmentId = 10, JobTitleId = 10, IsActive = true }
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
                new EmployeeDataImportExport { ImportExportId = 1, Type = "Import", FileName = "employees.xlsx", FilePath = "/uploads/employees.xlsx", ImportExportDate = new DateTime(2022, 5, 1), IsActive = true },
                new EmployeeDataImportExport { ImportExportId = 2, Type = "Export", FileName = "employees_export.xlsx", FilePath = "/exports/employees_export.xlsx", ImportExportDate = new DateTime(2022, 5, 2), IsActive = true },
                new EmployeeDataImportExport { ImportExportId = 3, Type = "Import", FileName = "employees_backup.xlsx", FilePath = "/backups/employees_backup.xlsx", ImportExportDate = new DateTime(2022, 5, 3), IsActive = true },
                new EmployeeDataImportExport { ImportExportId = 4, Type = "Export", FileName = "employees_archive.xlsx", FilePath = "/archives/employees_archive.xlsx", ImportExportDate = new DateTime(2022, 5, 4), IsActive = true },
                new EmployeeDataImportExport { ImportExportId = 5, Type = "Import", FileName = "employees_data.xlsx", FilePath = "/uploads/employees_data.xlsx", ImportExportDate = new DateTime(2022, 5, 5), IsActive = true },
                new EmployeeDataImportExport { ImportExportId = 6, Type = "Export", FileName = "employees_info.xlsx", FilePath = "/exports/employees_info.xlsx", ImportExportDate = new DateTime(2022, 5, 6), IsActive = true },
                new EmployeeDataImportExport { ImportExportId = 7, Type = "Import", FileName = "employees_sheet.xlsx", FilePath = "/uploads/employees_sheet.xlsx", ImportExportDate = new DateTime(2022, 5, 7), IsActive = true },
                new EmployeeDataImportExport { ImportExportId = 8, Type = "Export", FileName = "employees_export_info.xlsx", FilePath = "/exports/employees_export_info.xlsx", ImportExportDate = new DateTime(2022, 5, 8), IsActive = true },
                new EmployeeDataImportExport { ImportExportId = 9, Type = "Import", FileName = "employees_data_sheet.xlsx", FilePath = "/uploads/employees_data_sheet.xlsx", ImportExportDate = new DateTime(2022, 5, 9), IsActive = true },
                new EmployeeDataImportExport { ImportExportId = 10, Type = "Export", FileName = "employees_info_backup.xlsx", FilePath = "/exports/employees_info_backup.xlsx", ImportExportDate = new DateTime(2022, 5, 10), IsActive = true }
            );

            base.OnModelCreating(modelBuilder);
        }
        #endregion Seed
    }
}
