using System.ComponentModel.DataAnnotations;

namespace IdentityMailChatApp.Web.Entities
{
    public class Email
    {
        [Key]
        public int MessageId { get; set; }

        [Required, EmailAddress]
        public string SenderEmail { get; set; }

        [Required, EmailAddress]
        public string ReceiverEmail { get; set; }

        [Required, MaxLength(150)]
        public string Subject { get; set; }

        [Required]
        public string MessageDetail { get; set; }

        public bool IsRead { get; set; } = false;

        // UTC tarih ve saat kullanarak zaman dilimi sorunlarını engellemek
        public DateTime SendDate { get; set; } = DateTime.UtcNow;

        public bool IsDeleted { get; internal set; }


    }
}
