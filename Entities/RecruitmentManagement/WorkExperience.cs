using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.RecruitmentManagement
{
    public class WorkExperience
    {
        [Key]
        public int WorkExperienceId { get; set; }
        public int? ApplicantId { get; set; }
        public Applicant Applicant { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Duration { get; set; }

        
    }
}
