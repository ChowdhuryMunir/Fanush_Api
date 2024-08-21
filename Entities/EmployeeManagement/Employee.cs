using Fanush.Entities.PayrollManagement;
using Fanush.Entities.PerformenceManagement;
using Fanush.Entities.TimeAndAttendence;
using Microsoft.Owin.BuilderProperties;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Fanush.Models.EmployeeManagement
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public string PresentAddress { get; set; }

        public string PermanentAddress { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string NationalId { get; set; }
        public string PassportNumber { get; set; }
        public DateTime DateOfJoining { get; set; }

        public string? ImagePath { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        //Navigation Property
        public int JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }



        // Additional properties
        public string EmergencyContactNumber { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string BloodGroup { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }

        // Lifecycle and audit properties
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
        public string UpdatedBy { get; set; }

        // Relationships
       
        public virtual List<EmployeeLifecycle>? EmployeeLifecycles { get; set; }
        // Time And Attendence
        public virtual List<ClockInOut>? ClockInOuts { get; set; } = new List<ClockInOut>();
        public virtual List<AbsenceReport>? AbsenceReports { get; set; } = new List<AbsenceReport>();
        public virtual List<Leave>? Leaves { get; set; } = new List<Leave>();
        public virtual List<Overtime>? Overtimes { get; set; } = new List<Overtime>();
        public virtual List<PayrollIntegration>? PayrollIntegrations { get; set; } = new List<PayrollIntegration>();
        // Performence Management
        public virtual List<Goal>? Goals { get; set; } = new List<Goal>();
        public virtual List<PerformanceReview>? PerformanceReviews { get; set; } = new List<PerformanceReview>();
        public virtual List<DevelopmentPlan>? DevelopmentPlans { get; set; } = new List<DevelopmentPlan>();
        public virtual List<PerformanceReport>? PerformanceReports { get; set; } = new List<PerformanceReport>();
        public virtual List<PayrollCalculation>? PayrollCalculations { get; set; } = new List<PayrollCalculation>();



    }

}