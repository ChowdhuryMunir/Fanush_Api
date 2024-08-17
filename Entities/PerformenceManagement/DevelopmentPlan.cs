using Fanush.Models.EmployeeManagement;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fanush.Entities.PerformenceManagement
{
    public class DevelopmentPlan
    {
        [Key]
        public int DevelopmentPlanId { get; set; }

        [Required(ErrorMessage = "EmployeeId is required.")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "TargetCompletionDate is required.")]
        public DateTime TargetCompletionDate { get; set; }

        public enum DevelopmentPlanStatuses { Approved, Pending, Rejected }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DevelopmentPlanStatuses DevelopmentPlanStatus { get; set; }

        [Required(ErrorMessage = "Progress is required.")]
        [Range(0, 100, ErrorMessage = "Progress must be between 0 and 100.")]
        public int Progress { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        // Additional properties for real-time HR management

        [Display(Name = "Feedback")]
        public string Feedback { get; set; } // Feedback received during the development process

        [Display(Name = "Resources")]
        public string Resources { get; set; } // Resources allocated or required for the development plan

        [Display(Name = "Completion Date")]
        [DataType(DataType.Date)]
        public DateTime? CompletionDate { get; set; } // Actual completion date of the development plan
    }
}
