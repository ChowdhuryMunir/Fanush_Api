using System.ComponentModel.DataAnnotations;

namespace Fanush.Models.EmployeeManagement
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string? EmployeeName { get; set; }


        public string? ContactNumber { get; set; }


        public string? Email { get; set; }


        public DateTime? DateOfBirth { get; set; }

        public string? EmergencyContact { get; set; }

        public string? Gender { get; set; }


        public DateTime? DateJoined { get; set; }


        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }

        public int? JobTitleId { get; set; }

        public JobTitle? JobTitle { get; set; }

        public virtual List<EmployeeLifecycle>? EmployeeLifecycle { get; set; }  = new List<EmployeeLifecycle>();
        public bool IsActive { get; set; }
    }
}