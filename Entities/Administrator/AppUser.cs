using Microsoft.AspNetCore.Identity;
using Microsoft.Owin.BuilderProperties;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fanush.Entities.Administrator
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [NotMapped]
        public string? FullName => $"{FirstName} {LastName}";
    }
}
