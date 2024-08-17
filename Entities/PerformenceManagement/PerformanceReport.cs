using Fanush.Models.EmployeeManagement;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fanush.Entities.PerformenceManagement
{
    public class PerformanceReport
    {
        [Key]

        public int PerformanceReportId { get; set; }

        [Required(ErrorMessage = "EmployeeId is required.")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public int EvaluatorId { get; set; } // Foreign key linking to the Evaluator (could also be an Employee or User)

        [Required]
        public DateTime EvaluationDate { get; set; } // Date when the evaluation was completed

        public int? PerformanceScore { get; set; } // Numerical or categorical score representing overall performance

        public string? GoalsMet { get; set; } // Count or summary of objectives met

        public string Strengths { get; set; } // Description of the employee's strengths

        public string AreasForImprovement { get; set; } // Description of areas needing improvement

        public string Achievements { get; set; } // Notable accomplishments

        public string DevelopmentPlan { get; set; } // Summary of planned development activities

        public string Comments { get; set; } // Additional comments from the evaluator

        public string OverallRating { get; set; } // Aggregate rating or performance classification

        public DateTime? ReviewPeriodStart { get; set; } // Start date of the performance review period

        public DateTime? ReviewPeriodEnd { get; set; } // End date of the performance review period

        public string Status { get; set; } // Current status of the performance report

        public string ActionItems { get; set; } // Specific action items resulting from the evaluation, like set up, follow up meeting etc.


    }
}