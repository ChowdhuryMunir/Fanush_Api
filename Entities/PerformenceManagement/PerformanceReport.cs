using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.PerformenceManagement
{
    public class PerformanceReport
    {
        [Required(ErrorMessage = "EmployeeId is required.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "StartDate is required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "EndDate is required.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "ReportData is required.")]
        public string ReportData { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        // Additional properties for real-time HR management
        [Display(Name = "Performance Metrics")]
        public string PerformanceMetrics { get; set; } // Performance metrics tracked during the period

        [Display(Name = "Ratings")]
        public string Ratings { get; set; } // Ratings given for different aspects of performance

        [Display(Name = "Comments")]
        public string Comments { get; set; } // Comments or feedback provided in the performance report
    }
}
