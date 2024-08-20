using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fanush.Entities.RecruitmentManagement
{
    public class Applicant
    {
        [Key]
        public int ApplicantId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string ApplicantName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Resume is required.")]
        public string? ResumeUrl { get; set; }

        [NotMapped]
        public IFormFile? ResumeFile { get; set; }


        public enum Statuses { Approved, Pending, Rejected }

        public Statuses Status { get; set; }

        [Display(Name = "Applied Date")]
        public DateTime AppliedDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "LinkedIn Profile")]
        [Url(ErrorMessage = "Invalid URL format for LinkedIn profile.")]
        public string LinkedinProfileUrl { get; set; }

        // Additional properties
        [Display(Name = "Address")]
        public string Address { get; set; } // Applicant's address

        [Display(Name = "City")]
        public string City { get; set; } // Applicant's city

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; } // Applicant's zip code

        [Display(Name = "Country")]
        public string Country { get; set; } // Applicant's country

        [Display(Name = "Expected Salary")]
        public decimal ExpectedSalary { get; set; } // Applicant's expected salary



        [Display(Name = "Languages")]
        public string Languages { get; set; } // Languages known by the applicant

        [Display(Name = "Skills")]
        public string Skills { get; set; } // Skills possessed by the applicant

        [Display(Name = "References")]
        public string References { get; set; } // References provided by the applicant



        public virtual List<Interview>? Interviews { get; set; } = new List<Interview>();
        public virtual List<Education>? Educations { get; set; } = new List<Education>();
        public virtual List<WorkExperience>? WorkExperiences { get; set; } = new List<WorkExperience>();

    }
}

