using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.RecruitmentManagement
{
    public class JobPosting
    {
        [Key]
        public int JobPostingId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "IsInternal is required.")]
        public bool IsInternal { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        [Display(Name = "Posting Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Posting date is required.")]
        public DateTime PostingDate { get; set; }

        [Display(Name = "Application Deadline")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Application deadline is required.")]
        public DateTime ApplicationDeadline { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Start date is required.")]
        public DateTime StartDate { get; set; }

        // Location
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }

        // Company
        [Required(ErrorMessage = "Company name is required.")]
        public string CompanyName { get; set; }

        [Url(ErrorMessage = "Invalid URL format.")]
        [Display(Name = "Company Logo")]
        public string CompanyLogo { get; set; }

        [Url(ErrorMessage = "Invalid URL format.")]
        [Display(Name = "Company Website")]
        public string CompanyWebsite { get; set; }

        // Contact Information
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Required(ErrorMessage = "Contact email is required.")]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        [Required(ErrorMessage = "Contact phone number is required.")]
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

