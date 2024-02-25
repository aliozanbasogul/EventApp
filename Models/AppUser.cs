using Microsoft.AspNetCore.Identity;

namespace EventApp.Models
{
    public class AppUser: IdentityUser
    {
        public string? FullName { get; set; }
    }
}