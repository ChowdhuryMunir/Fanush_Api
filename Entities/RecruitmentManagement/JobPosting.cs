using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.RecruitmentManagement
{
    public class JobPosting
    {
        [Key]
        public int JobPostingId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }


        public bool IsInternal { get; set; }

        public bool IsActive { get; set; }

        [Display(Name = "Posting Date")]
        [DataType(DataType.Date)]
        public DateTime PostingDate { get; set; }

        [Display(Name = "Application Deadline")]
        [DataType(DataType.Date)]
        public DateTime ApplicationDeadline { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        // Location
        public string City { get; set; }

        // Contact Information
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        [Display(Name = "Contact Phone")]
        public string ContactPhone { get; set; }

        // Additional Information
        [Display(Name = "Salary Information")]
        public string SalaryInformation { get; set; }

        public string Requirements { get; set; }

        // Additional Properties
        [Display(Name = "Job Type")]
        public string JobType { get; set; } // Full-time, part-time, contract, etc.

        [Display(Name = "Experience Required")]
        public string ExperienceRequired { get; set; } // Years of experience required

        [Display(Name = "Education Required")]
        public string EducationRequired { get; set; } // Minimum education level required

        [Display(Name = "Skills Required")]
        public string SkillsRequired { get; set; } // Key skills required for the job

        [Display(Name = "Benefits Offered")]
        public string BenefitsOffered { get; set; } // Benefits offered with the job (e.g., healthcare, retirement plans, etc.)

        [Display(Name = "Work Schedule")]
        public string WorkSchedule { get; set; } // Work schedule details (e.g., Monday to Friday, flexible hours, etc.)

        [Display(Name = "Remote Work")]
        public bool IsRemoteWork { get; set; } // Indicates if remote work is allowed for the job
    }


}

