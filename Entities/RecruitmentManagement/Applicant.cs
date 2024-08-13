using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.RecruitmentManagement
{
    public class Applicant
    {
        [Key]
        public int ApplicantId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Resume is required.")]
        [Url(ErrorMessage = "Invalid URL format for resume.")]
        public string ResumeUrl { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Is Active status is required.")]
        public bool IsActive { get; set; }

        [Display(Name = "Applied Date")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Applied date is required.")]
        public DateTime AppliedDate { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "LinkedIn Profile")]
        [Url(ErrorMessage = "Invalid URL format for LinkedIn profile.")]
        public string LinkedInProfileUrl { get; set; }

        // Additional properties
        [Display(Name = "Address")]
        public string Address { get; set; } // Applicant's address

        [Display(Name = "City")]
        public string City { get; set; } // Applicant's city

        [Display(Name = "State")]
        public string State { get; set; } // Applicant's state

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; } // Applicant's zip code

        [Display(Name = "Country")]
        public string Country { get; set; } // Applicant's country

        [Display(Name = "Expected Salary")]
        public decimal ExpectedSalary { get; set; } // Applicant's expected salary

        [Display(Name = "Work Experience")]
        public string WorkExperience { get; set; } // Applicant's work experience

        [Display(Name = "Education")]
        public string Education { get; set; } // Applicant's education

        [Display(Name = "Certifications")]
        public string Certifications { get; set; } // Applicant's certifications

        [Display(Name = "Languages")]
        public string Languages { get; set; } // Languages known by the applicant

        [Display(Name = "Skills")]
        public string Skills { get; set; } // Skills possessed by the applicant

        [Display(Name = "References")]
        public string References { get; set; } // References provided by the applicant
    }
}

