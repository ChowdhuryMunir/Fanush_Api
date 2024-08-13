using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.RecruitmentManagement
{
    public class Interview
    {
        [Key]
        public int InterviewId { get; set; }

        [Required(ErrorMessage = "DateTime is required.")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        public string Notes { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        [Display(Name = "Interviewer")]
        [Required(ErrorMessage = "Interviewer is required.")]
        public string Interviewer { get; set; }

        [Display(Name = "Applicant")]
        [Required(ErrorMessage = "Applicant is required.")]
        public string Applicant { get; set; }

        [Display(Name = "Interview Type")]
        [Required(ErrorMessage = "Interview type is required.")]
        public string InterviewType { get; set; }

        [Display(Name = "Duration (minutes)")]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive integer.")]
        public int DurationMinutes { get; set; }

        // Additional properties
        [Display(Name = "Feedback")]
        public string Feedback { get; set; } // Feedback provided during the interview

        [Display(Name = "Outcome")]
        public string Outcome { get; set; } // Outcome of the interview (e.g., hired, not hired, pending, etc.)

        [Display(Name = "Follow-Up")]
        public string FollowUp { get; set; } // Follow-up actions required after the interview

        [Display(Name = "Feedback Requested")]
        public bool IsFeedbackRequested { get; set; } // Indicates if feedback is requested from the interviewer

        [Display(Name = "Additional Rounds")]
        public int AdditionalRounds { get; set; } // Number of additional interview rounds scheduled
    }


}

