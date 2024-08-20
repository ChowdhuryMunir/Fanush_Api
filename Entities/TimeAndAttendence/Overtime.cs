using Fanush.Models.EmployeeManagement;
using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.TimeAndAttendence
{
    public class Overtime
    {
        [Key]
        public int OvertimeId { get; set; }

        [Required(ErrorMessage = "EmployeeId is required.")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Hours is required.")]
        //[Range(0, decimal.MaxValue, ErrorMessage = "Hours must be a non-negative value.")]
        public decimal Hours { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        // Additional properties
        [Display(Name = "Overtime Type")]
        public string OvertimeType { get; set; } // Type of overtime (e.g., mandatory, voluntary)

        [Display(Name = "Approval Status")]
        public string ApprovalStatus { get; set; } // Status of overtime approval (e.g., pending, approved, rejected)

        [Display(Name = "Approved By")]
        public string? ApprovedBy { get; set; } // Name of the person who approved the overtime

        [Display(Name = "Approval Date")]
        [DataType(DataType.DateTime)]
        public DateTime? ApprovalDate { get; set; } // Date and time when the overtime was approved

        [Display(Name = "Reason")]
        public string Reason { get; set; } // Reason for overtime

        [Display(Name = "Attachment")]
        public string? AttachmentUrl { get; set; } // URL of any attachment related to the overtime record

        // Real-time HRM properties
        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; } // Date and time when the overtime record was created

        [Display(Name = "Last Modified Date")]
        [DataType(DataType.DateTime)]
        public DateTime LastModifiedDate { get; set; } // Date and time when the overtime record was last modified

        [Display(Name = "CreatedBy")]
        public string CreatedBy { get; set; } // Name of the user who created the overtime record

        [Display(Name = "Last Modified By")]
        public string LastModifiedBy { get; set; } // Name of the user who last modified the overtime record

        [Display(Name = "Department")]
        public string Department { get; set; } // Department associated with the overtime record

        [Display(Name = "Project")]
        public string Project { get; set; } // Project associated with the overtime record

    }
}
