using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.RecruitmentManagement
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        public int? ApplicantId { get; set; }
        public Applicant Applicant { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required]
        public string Institution { get; set; }

        [Required]
        public string PassingYear { get; set; }

        [Required]
        public decimal Result { get; set; }

       
    }
}

