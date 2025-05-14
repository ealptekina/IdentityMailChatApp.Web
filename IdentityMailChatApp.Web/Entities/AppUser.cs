using Microsoft.AspNetCore.Identity;

namespace IdentityMailChatApp.Web.Entities
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? City { get; set; }
        public string? About { get; set; }
    }
}
