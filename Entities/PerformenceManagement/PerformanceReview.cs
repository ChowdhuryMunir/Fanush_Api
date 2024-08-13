using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.PerformenceManagement
{
    public class PerformanceReview
    {
        [Required(ErrorMessage = "EmployeeId is required.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "ReviewerId is required.")]
        public int ReviewerId { get; set; }

        [Required(ErrorMessage = "StartDate is required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "EndDate is required.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Feedback is required.")]
        public string Feedback { get; set; }

        [Required(ErrorMessage = "SelfEvaluation is required.")]
        public string SelfEvaluation { get; set; }

        [Required(ErrorMessage = "IsCompleted is required.")]
        public bool IsCompleted { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        // Additional properties for real-time HR management
        [Display(Name = "Performance Rating")]
        [Range(1, 5, ErrorMessage = "Performance rating must be between 1 and 5.")]
        public int PerformanceRating { get; set; } // Overall performance rating given by the reviewer

        [Display(Name = "Comments")]
        public string Comments { get; set; } // Additional comments or notes from the reviewer

        [Display(Name = "Development Areas")]
        public string DevelopmentAreas { get; set; } // Areas identified for employee development

        [Display(Name = "Goals")]
        public string Goals { get; set; } // Goals set during the performance review process

        [Display(Name = "Next Review Date")]
        [DataType(DataType.Date)]
        public DateTime? NextReviewDate { get; set; } // Date for the next performance review

        [Display(Name = "Review Type")]
        public string ReviewType { get; set; } // Type of performance review (e.g., annual, quarterly)
    }
}
