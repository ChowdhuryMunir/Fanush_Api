using Fanush.Entities.RecruitmentManagement;
using Fanush.Entities.TimeAndAttendence;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL
{
    public class FanushDbContext : DbContext
    {
        public FanushDbContext(DbContextOptions<FanushDbContext> options) : base(options) { }

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

        



        #endregion RecruitManagement

        #region TimeAndAttendence
        public DbSet<ClockInOut> ClockInOuts { get; set; }
        public DbSet<AbsenceReport> AbsenceReports { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Overtime> Overtimes { get; set; }
        public DbSet<PayrollIntegration> PayrollIntegrations { get; set; }

        #endregion TimeAndAttendence

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
      new Employee
      {
          EmployeeId = 1,
          FirstName = "John",
          LastName = "Doe",
          DateOfBirth = new DateTime(1985, 5, 20),
          Gender = "Male",
          PresentAddress= "abc",
          PermanentAddress="abc",
          PhoneNumber = "1234567890",
          Email = "john.doe@example.com",
          NationalId = "1234567890123",
          PassportNumber = "A12345678",
          DateOfJoining = new DateTime(2010, 1, 1),
          JobTitleId = 1,
          DepartmentId = 1,
          EmergencyContactNumber = "9876543210",
          FathersName = "James Doe",
          MothersName = "Anna Doe",
          BloodGroup = "O+",
          Religion = "Christian",
          MaritalStatus = "Married",
          Nationality = "American",
          ProfileImagePath = "/images/profiles/john_doe.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
      },
      new Employee
      {
          EmployeeId = 2,
          FirstName = "Jane",
          LastName = "Smith",
          DateOfBirth = new DateTime(1990, 3, 15),
          Gender = "Female",
          PresentAddress = "abc",
          PermanentAddress = "abc",
          PhoneNumber = "9876543210",
          Email = "jane.smith@example.com",
          NationalId = "9876543210987",
          PassportNumber = "B23456789",
          DateOfJoining = new DateTime(2015, 8, 15),
          JobTitleId = 2,
          DepartmentId = 2,
          EmergencyContactNumber = "1234567890",
          FathersName = "Robert Smith",
          MothersName = "Laura Smith",
          BloodGroup = "A+",
          Religion = "Christian",
          MaritalStatus = "Single",
          Nationality = "Canadian",
          ProfileImagePath = "/images/profiles/jane_smith.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
      },
      new Employee
      {
          EmployeeId = 3,
          FirstName = "Michael",
          LastName = "Johnson",
          DateOfBirth = new DateTime(1982, 9, 20),
          Gender = "Male",
          PresentAddress = "abc",
          PermanentAddress = "abc",
          PhoneNumber = "5555555555",
          Email = "michael.johnson@example.com",
          NationalId = "5555555555555",
          PassportNumber = "C34567890",
          DateOfJoining = new DateTime(2008, 3, 5),
          JobTitleId = 3,
          DepartmentId = 3,
          EmergencyContactNumber = "6666666666",
          FathersName = "David Johnson",
          MothersName = "Emily Johnson",
          BloodGroup = "B+",
          Religion = "Christian",
          MaritalStatus = "Married",
          Nationality = "British",
          ProfileImagePath = "/images/profiles/michael_johnson.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
      },
      new Employee
      {
          EmployeeId = 4,
          FirstName = "Emily",
          LastName = "Brown",
          DateOfBirth = new DateTime(1993, 12, 15),
          Gender = "Female",
          PresentAddress = "abc",
          PermanentAddress = "abc",
          PhoneNumber = "4444444444",
          Email = "emily.brown@example.com",
          NationalId = "4444444444444",
          PassportNumber = "D45678901",
          DateOfJoining = new DateTime(2019, 11, 12),
          JobTitleId = 4,
          DepartmentId = 4,
          EmergencyContactNumber = "3333333333",
          FathersName = "William Brown",
          MothersName = "Elizabeth Brown",
          BloodGroup = "AB-",
          Religion = "Christian",
          MaritalStatus = "Single",
          Nationality = "Australian",
          ProfileImagePath = "/images/profiles/emily_brown.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
      },
      new Employee
      {
          EmployeeId = 5,
          FirstName = "David",
          LastName = "Wilson",
          DateOfBirth = new DateTime(1978, 8, 25),
          Gender = "Male",
          PresentAddress = "abc",
          PermanentAddress = "abc",
          PhoneNumber = "7777777777",
          Email = "david.wilson@example.com",
          NationalId = "7777777777777",
          PassportNumber = "E56789012",
          DateOfJoining = new DateTime(2012, 6, 30),
          JobTitleId = 5,
          DepartmentId = 5,
          EmergencyContactNumber = "8888888888",
          FathersName = "Thomas Wilson",
          MothersName = "Sophia Wilson",
          BloodGroup = "O-",
          Religion = "Christian",
          MaritalStatus = "Married",
          Nationality = "New Zealander",
          ProfileImagePath = "/images/profiles/david_wilson.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
      },
      new Employee
      {
          EmployeeId = 6,
          FirstName = "Sophia",
          LastName = "Martinez",
          DateOfBirth = new DateTime(1989, 4, 5),
          Gender = "Female",
          PresentAddress = "abc",
          PermanentAddress = "abc",
          PhoneNumber = "2222222222",
          Email = "sophia.martinez@example.com",
          NationalId = "2222222222222",
          PassportNumber = "F67890123",
          DateOfJoining = new DateTime(2016, 10, 20),
          JobTitleId = 6,
          DepartmentId = 6,
          EmergencyContactNumber = "9999999999",
          FathersName = "Carlos Martinez",
          MothersName = "Maria Martinez",
          BloodGroup = "A-",
          Religion = "Catholic",
          MaritalStatus = "Single",
          Nationality = "Spanish",
          ProfileImagePath = "/images/profiles/sophia_martinez.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
      },
      new Employee
      {
          EmployeeId = 7,
          FirstName = "Daniel",
          LastName = "Taylor",
          DateOfBirth = new DateTime(1980, 3, 10),
          Gender = "Male",
          PresentAddress = "abc",
          PermanentAddress = "abc",
          PhoneNumber = "6666666666",
          Email = "daniel.taylor@example.com",
          NationalId = "6666666666666",
          PassportNumber = "G78901234",
          DateOfJoining = new DateTime(2005, 7, 18),
          JobTitleId = 7,
          DepartmentId = 7,
          EmergencyContactNumber = "1111111111",
          FathersName = "Henry Taylor",
          MothersName = "Alice Taylor",
          BloodGroup = "B-",
          Religion = "Jewish",
          MaritalStatus = "Married",
          Nationality = "South African",
          ProfileImagePath = "/images/profiles/daniel_taylor.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
      },
      new Employee
      {
          EmployeeId = 8,
          FirstName = "Olivia",
          LastName = "Anderson",
          DateOfBirth = new DateTime(1995, 6, 28),
          Gender = "Female",
          PresentAddress = "abc",
          PermanentAddress = "abc",
          PhoneNumber = "9999999999",
          Email = "olivia.anderson@example.com",
          NationalId = "9999999999999",
          PassportNumber = "H89012345",
          DateOfJoining = new DateTime(2020, 4, 22),
          JobTitleId = 8,
          DepartmentId = 8,
          EmergencyContactNumber = "7777777777",
          FathersName = "George Anderson",
          MothersName = "Eleanor Anderson",
          BloodGroup = "AB+",
          Religion = "Christian",
          MaritalStatus = "Single",
          Nationality = "American",
          ProfileImagePath = "/images/profiles/olivia_anderson.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
      },
      new Employee
      {
          EmployeeId = 9,
          FirstName = "Ethan",
          LastName = "Thomas",
          DateOfBirth = new DateTime(1987, 11, 8),
          Gender = "Male",
          PresentAddress = "abc",
          PermanentAddress = "abc",
          PhoneNumber = "3333333333",
          Email = "ethan.thomas@example.com",
          NationalId = "3333333333333",
          PassportNumber = "I90123456",
          DateOfJoining = new DateTime(2018, 9, 3),
          JobTitleId = 9,
          DepartmentId = 9,
          EmergencyContactNumber = "5555555555",
          FathersName = "Samuel Thomas",
          MothersName = "Lily Thomas",
          BloodGroup = "O+",
          Religion = "Christian",
          MaritalStatus = "Married",
          Nationality = "Indian",
          ProfileImagePath = "/images/profiles/ethan_thomas.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
      },
      new Employee
      {
          EmployeeId = 10,
          FirstName = "Ava",
          LastName = "White",
          DateOfBirth = new DateTime(1991, 2, 18),
          Gender = "Female",
          PresentAddress = "abc",
          PermanentAddress = "abc",
          PhoneNumber = "8888888888",
          Email = "ava.white@example.com",
          NationalId = "8888888888888",
          PassportNumber = "J01234567",
          DateOfJoining = new DateTime(2013, 12, 10),
          JobTitleId = 10,
          DepartmentId = 10,
          EmergencyContactNumber = "4444444444",
          FathersName = "Frank White",
          MothersName = "Grace White",
          BloodGroup = "A+",
          Religion = "Christian",
          MaritalStatus = "Single",
          Nationality = "Canadian",
          ProfileImagePath = "/images/profiles/ava_white.jpg",
          IsActive = true,
          CreatedOn = DateTime.UtcNow,
          CreatedBy = "Admin",
          UpdatedOn = DateTime.UtcNow,
          UpdatedBy = "Admin"
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

            modelBuilder.Entity<Applicant>(entity =>
            {
                // Configuring the Status enum as a string in the database
                entity.Property(e => e.Status)
                      .HasConversion<string>();

                // Configuring WorkExperiences and Educations as complex types if necessary
                entity.OwnsOne(a => a.WorkExperience);
                entity.OwnsOne(a => a.Education);
            });



            base.OnModelCreating(modelBuilder);
        }
        #endregion Seed




    }
}
