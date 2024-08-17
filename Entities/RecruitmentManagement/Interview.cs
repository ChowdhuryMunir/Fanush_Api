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

        //navigation property 
        public int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }

        public enum InterviewTypes { PreliminaryTest, Written, OralTest }

        [Required]
        public InterviewTypes InterviewType { get; set; }

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


    }
}

