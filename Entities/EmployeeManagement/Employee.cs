using Microsoft.Owin.BuilderProperties;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace Fanush.Models.EmployeeManagement
{
    public class Employee
    {
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
        public string JobTitle { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        // Additional properties
        public string EmergencyContactNumber { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string BloodGroup { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }

        // Profile image path
        public string ProfileImagePath { get; set; }

        // Lifecycle and audit properties
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

        // Relationships
        public ICollection<EmployeeLifecycle> EmployeeLifecycles { get; set; }
       // public ICollection<AcademicInfo> AcademicInfos { get; set; }
    }

}