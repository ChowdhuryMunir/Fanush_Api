using Fanush.Models.EmployeeManagement;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fanush.Entities.PerformenceManagement
{
    public class Goal
    {
        [Key]
        public int GoalId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "StartDate is required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "EndDate is required.")]
        public DateTime EndDate { get; set; }

        [Display(Name = "AssignedToUserId")]
        [Required(ErrorMessage = "AssignedToUserId is required.")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        public enum GoalStatuses { Approved, Pending, Rejected }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public GoalStatuses GoalStatus { get; set; }

        [Required(ErrorMessage = "Progress is required.")]
        [Range(0, 100, ErrorMessage = "Progress must be between 0 and 100.")]
        public int Progress { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        // Additional properties for real-time HR management
        [Display(Name = "Last Updated Date")]
        [DataType(DataType.DateTime)]
        public DateTime LastUpdatedDate { get; set; } // Date and time when the goal was last updated

        [Display(Name = "Updated By")]
        public string UpdatedBy { get; set; } // Name of the user who last updated the goal

        [Display(Name = "Completion Date")]
        [DataType(DataType.DateTime)]
        public DateTime? CompletionDate { get; set; } // Date and time when the goal was completed

        [Display(Name = "Assigned By")]
        public int AssignedByUserId { get; set; } // User ID of the person who assigned the goal

        [Display(Name = "Comments")]
        public string Comments { get; set; } // Comments or notes related to the goal



    }
}
