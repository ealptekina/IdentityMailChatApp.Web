using IdentityMailChatApp.Web.Entities;

namespace IdentityMailChatApp.Web.ViewModels
{
    public class EmailDetailViewModel
    {
        public Email Message { get; set; }           // Mesajın tüm bilgileri
        public string SenderProfilePictureUrl { get; set; }  // Gönderenin profil fotoğrafı URL'si
        public string SenderName { get; set; }       // Gönderenin adı
        public string SenderEmail { get; set; }      // Gönderenin e-posta adresi
    }

}
