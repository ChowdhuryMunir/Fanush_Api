using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.BenefitsAdministration
{
    public class ProviderIntegration
    {
        [Required(ErrorMessage = "ProviderName is required.")]
        public string ProviderName { get; set; }

        [Required(ErrorMessage = "IntegrationType is required.")]
        public string IntegrationType { get; set; }

        [Required(ErrorMessage = "IntegrationKey is required.")]
        public string IntegrationKey { get; set; }

        [Required(ErrorMessage = "IntegrationStatus is required.")]
        public bool IntegrationStatus { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }
    }
}
