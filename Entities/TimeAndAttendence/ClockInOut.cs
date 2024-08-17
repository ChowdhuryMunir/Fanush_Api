using Fanush.Models.EmployeeManagement;
using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.TimeAndAttendence
{
    public class ClockInOut
    {
        [Key]
        public int ClockInOutId { get; set; }

        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeId { get; set; }
         
        public Employee Employee { get; set; }

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
        public string? Notes { get; set; }

        [DataType(DataType.Time)]
        public DateTime ClockInTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime ClockOutTime { get; set; }

        [Display(Name = "Worked Hours")]
        public TimeSpan Duration
        {
            get
            {
                if (ClockOutTime > ClockInTime)
                {
                    return ClockOutTime - ClockInTime;
                }
                return TimeSpan.Zero; // Return TimeSpan.Zero if the times are invalid
            }
        }

        [Display(Name = "Late Arrival")]
        public bool IsLateArrival { get; set; }

        [Display(Name = "Early Departure")]
        public bool IsEarlyDeparture { get; set; }

        [Display(Name = "Is Workday")]
        public bool IsWorkday { get; set; }

        [Display(Name = "Overtime Hours")]
        public decimal OvertimeHours { get; set; }

        [Display(Name = "Is Overtime")]
        public bool IsOvertime { get; set; }

        [Display(Name = "Approved By")]
        public string ApprovedBy { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Late Arrival Reason")]
        public string LateArrivalReason { get; set; } // Reason for late arrival

        [Display(Name = "Early Departure Reason")]
        public string? EarlyDepartureReason { get; set; } // Reason for early departure
    }
}
