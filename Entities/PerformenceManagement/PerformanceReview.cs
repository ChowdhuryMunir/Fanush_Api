using Fanush.Models.EmployeeManagement;
using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.PerformenceManagement
{
    public class PerformanceReview
    {
        [Key]

        public int PerformanceReviewId { get; set; }

        [Required(ErrorMessage = "EmployeeId is required.")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required(ErrorMessage = "ReviewerId is required.")]
        public int ReviewerId { get; set; }

        [Required(ErrorMessage = "Feedback is required.")]
        public string Feedback { get; set; }

        // Additional properties for real-time HR management
        [Display(Name = "Performance Rating")]
        [Range(1, 5, ErrorMessage = "Performance rating must be between 1 and 5.")]
        public int PerformanceRating { get; set; } // Overall performance rating given by the reviewer

        [Display(Name = "Comments")]
        public string Comments { get; set; } // Additional comments or notes from the reviewer

        [Display(Name = "Review Date")]
        [DataType(DataType.Date)]
        public DateTime? ReviewDate { get; set; } // Date for the  performance review

        [Display(Name = "Review Type")]
        public string ReviewType { get; set; } // Type of performance review (e.g., annual, quarterly)
    }
}
