using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.TimeAndAttendence
{
    public class ClockInOut
    {
        [Key]
        public int ClockInOutId { get; set; }

        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Timestamp is required.")]
        [Display(Name = "Timestamp")]
        [DataType(DataType.DateTime)]
        public DateTime Timestamp { get; set; }

        [Required(ErrorMessage = "Action is required.")]
        [StringLength(10, ErrorMessage = "Action must be at most 10 characters.")]
        public string Action { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Shift ID")]
        public int ShiftId { get; set; }

        [Display(Name = "Shift Start Time")]
        [DataType(DataType.Time)]
        public TimeSpan ShiftStartTime { get; set; }

        [Display(Name = "Shift End Time")]
        [DataType(DataType.Time)]
        public TimeSpan ShiftEndTime { get; set; }

        [Display(Name = "Shift Duration")]
        public TimeSpan ShiftDuration { get; set; }

        [Display(Name = "Late Arrival")]
        public bool IsLateArrival { get; set; }

        [Display(Name = "Early Departure")]
        public bool IsEarlyDeparture { get; set; }

        [Display(Name = "Is Workday")]
        public bool IsWorkday { get; set; }

        [Display(Name = "Worked Hours")]
        public decimal WorkedHours { get; set; }

        [Display(Name = "Break Hours")]
        public decimal BreakHours { get; set; }

        [Display(Name = "Total Hours")]
        public decimal TotalHours { get; set; }

        [Display(Name = "Overtime Hours")]
        public decimal OvertimeHours { get; set; }

        [Display(Name = "Is Overtime")]
        public bool IsOvertime { get; set; }

        [Display(Name = "Approved By")]
        public string ApprovedBy { get; set; }

        [Display(Name = "Approval Status")]
        public string ApprovalStatus { get; set; }

        [Display(Name = "Approval Comments")]
        public string ApprovalComments { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        // Additional properties
        [Display(Name = "Shift Type")]
        public string ShiftType { get; set; } // Type of shift (e.g., day shift, night shift)

        [Display(Name = "Break Start Time")]
        [DataType(DataType.Time)]
        public TimeSpan BreakStartTime { get; set; } // Start time of the break

        [Display(Name = "Break End Time")]
        [DataType(DataType.Time)]
        public TimeSpan BreakEndTime { get; set; } // End time of the break

        [Display(Name = "Late Arrival Reason")]
        public string LateArrivalReason { get; set; } // Reason for late arrival

        [Display(Name = "Early Departure Reason")]
        public string EarlyDepartureReason { get; set; } // Reason for early departure
    }
}
