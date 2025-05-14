using System.ComponentModel.DataAnnotations;

namespace IdentityMailChatApp.Web.ViewModels
{
    public class ProfileViewModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfileImageUrl { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
    }

}
