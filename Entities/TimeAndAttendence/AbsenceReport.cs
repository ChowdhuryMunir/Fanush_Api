using Fanush.Models.EmployeeManagement;
using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.TimeAndAttendence
{
    public class AbsenceReport
    {
        [Key]
        public int AbsenceReportId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required(ErrorMessage = "Start Date is required.")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required.")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Reason")]
        public string Reason { get; set; }

        [Display(Name = "Approver")]
        public string Approver { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Is Paid")]
        public bool IsPaid { get; set; } // New property for paid/unpaid absence

        [Display(Name = "Approved Date")]
        [DataType(DataType.DateTime)]
        public DateTime? ApprovedDate { get; set; } // Nullable property for approved date

        [Display(Name = "Is Half Day")]
        public bool IsHalfDay { get; set; } // New property for half day absence

        [Display(Name = "Half Day Type")]
        public string? HalfDayType { get; set; } // New property for half day type (morning/afternoon)
        public decimal DaysAbsent { get;  set; }
    }
}
