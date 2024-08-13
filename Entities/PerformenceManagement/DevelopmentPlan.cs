using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.PerformenceManagement
{
    public class DevelopmentPlan
    {
        [Required(ErrorMessage = "EmployeeId is required.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "GoalId is required.")]
        public int GoalId { get; set; }

        [Required(ErrorMessage = "ActionPlan is required.")]
        public string ActionPlan { get; set; }

        [Required(ErrorMessage = "TargetCompletionDate is required.")]
        public DateTime TargetCompletionDate { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Progress is required.")]
        [Range(0, 100, ErrorMessage = "Progress must be between 0 and 100.")]
        public int Progress { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        // Additional properties for real-time HR management
        [Display(Name = "Milestones")]
        public string Milestones { get; set; } // Milestones achieved or to be achieved

        [Display(Name = "Feedback")]
        public string Feedback { get; set; } // Feedback received during the development process

        [Display(Name = "Resources")]
        public string Resources { get; set; } // Resources allocated or required for the development plan

        [Display(Name = "Completion Date")]
        [DataType(DataType.Date)]
        public DateTime? CompletionDate { get; set; } // Actual completion date of the development plan
    }
}
