using System.ComponentModel.DataAnnotations;

namespace Fanush.Models.EmployeeManagement
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        //[Required(ErrorMessage = "Employee name is required.")]
        //[StringLength(100, ErrorMessage = "Employee name must be between 2 and 100 characters.", MinimumLength = 2)]
        public string EmployeeName { get; set; }

        //[Required(ErrorMessage = "Contact number is required.")]
        //[RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid contact number.")]
        public string ContactNumber { get; set; }

        //[Required(ErrorMessage = "Email address is required.")]
        //[EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        //[Required(ErrorMessage = "Emergency contact is required.")]
        public string EmergencyContact { get; set; }

        //[Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; }

       // Relational Data
        //[Required(ErrorMessage = "Department is required.")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        //[Required(ErrorMessage = "Job title is required.")]
        public int JobTitleId { get; set; }

        public JobTitle JobTitle { get; set; }

        public virtual List<EmployeeLifecycle> EmployeeLifecycle { get; set; }  = new List<EmployeeLifecycle>();
        public bool IsActive { get; set; }
    }
}