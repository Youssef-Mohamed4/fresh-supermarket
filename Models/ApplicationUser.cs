using Microsoft.AspNetCore.Identity;

namespace WebProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add additional profile properties here if needed
        public string? FullName { get; set; }
    }
}
