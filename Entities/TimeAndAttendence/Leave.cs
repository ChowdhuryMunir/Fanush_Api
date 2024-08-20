using Fanush.Models.EmployeeManagement;
using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.TimeAndAttendence
{
    public class Leave
    {
        [Key]
        public int LeaveId { get; set; }

        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }  

        [Required(ErrorMessage = "Leave Type is required.")]
        [StringLength(20, ErrorMessage = "Leave Type must be at most 20 characters.")]
        [Display(Name = "Leave Type")]
        public string LeaveType { get; set; }

        [Required(ErrorMessage = "Start Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [StringLength(10, ErrorMessage = "Status must be at most 10 characters.")]
        public string Status { get; set; }

        [Display(Name = "Reason")]
        public string Reason { get; set; }

        [Display(Name = "Requested By")]
        public string RequestedBy { get; set; }

        [Display(Name = "Approval Date")]
        [DataType(DataType.DateTime)]
        public DateTime? ApprovalDate { get; set; }

        [Display(Name = "Approver")]
        public string? Approver { get; set; }

        [Display(Name = "Approval Comments")]
        public string? ApprovalComments { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        // Additional properties
        [Display(Name = "Is Paid Leave")]
        public bool IsPaidLeave { get; set; } // Indicates if the leave is paid or unpaid

        [Display(Name = "Leave Category")]
        public string LeaveCategory { get; set; } // Category of leave (e.g., sick leave, vacation leave)
        public decimal NumberOfDays { get; set; }
    }
}
