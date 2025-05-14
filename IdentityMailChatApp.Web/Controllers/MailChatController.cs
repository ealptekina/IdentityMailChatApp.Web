using IdentityMailChatApp.Web.Context;
using IdentityMailChatApp.Web.Entities;
using IdentityMailChatApp.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMailChatApp.Web.Controllers
{
    public class MailChatController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public MailChatController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // Gelen kutusu (Inbox): Kullanıcının aldığı e-postalar
        [Authorize]
        public async Task<IActionResult> Inbox(string search)
        {
            // Kullanıcı bilgilerini al
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.email = user.Email;
            ViewBag.v1 = user.FirstName + " " + user.LastName;

            // Gelen mesajlar (silinmemiş)
            var inboxMessages = _context.Emails
                .Where(x => x.ReceiverEmail == user.Email && !x.IsDeleted);

            // Arama varsa filtrele
            if (!string.IsNullOrEmpty(search))
            {
                inboxMessages = inboxMessages.Where(m => m.Subject.Contains(search) || m.SenderEmail.Contains(search));
            }

            var messageList = await inboxMessages.OrderByDescending(x => x.SendDate).ToListAsync();

            // Okunmamış mesaj sayısı (inbox)
            var unreadCount = await _context.Emails
                .Where(e => e.ReceiverEmail == user.Email && !e.IsDeleted && !e.IsRead)
                .CountAsync();

            ViewBag.inboxMessageCount = unreadCount;

            return View(messageList);
        }


        // Gönderilen kutusu (SendBox): Kullanıcının gönderdiği e-postalar
        [Authorize]
        public async Task<IActionResult> SendBox(string search)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var userEmail = user.Email;

            // Kullanıcının gönderdiği e-postalar
            var sentEmailsQuery = _context.Emails
                .Where(e => e.SenderEmail == userEmail && !e.IsDeleted);

            // Arama varsa filtrele
            if (!string.IsNullOrEmpty(search))
            {
                sentEmailsQuery = sentEmailsQuery.Where(m =>
                    m.Subject.Contains(search) ||
                    m.ReceiverEmail.Contains(search));

                ViewBag.v1 = $"Arama Sonuçları: '{search}'";
            }
            

            var sentEmails = await sentEmailsQuery
                .OrderByDescending(e => e.SendDate)
                .ToListAsync();

            return View(sentEmails);
        }




        // Yeni mesaj oluşturma (GET)
        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        // Yeni mesaj gönderme (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMessage(Email email)
        {
            // Formdan gelmediği için manuel çıkarıyoruz
            ModelState.Remove("SenderEmail");

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);

                email.SenderEmail = user.Email;
                email.SendDate = DateTime.UtcNow;
                email.IsRead = false;

                _context.Emails.Add(email);
                await _context.SaveChangesAsync();

                TempData["SuccessMessage"] = "Mesaj başarıyla gönderildi.";
                return RedirectToAction("Inbox");
            }

            return View(email);
        }


        // Mesaj detayı (okuma)
        public async Task<IActionResult> DetailMessage(int messageId)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var message = await _context.Emails.FindAsync(messageId);

            if (message == null)
                return NotFound();

            message.IsRead = true;
            await _context.SaveChangesAsync();

            var senderUser = await _userManager.FindByEmailAsync(message.SenderEmail);

            var model = new EmailDetailViewModel
            {
                Message = message,
                SenderName = $"{senderUser.FirstName} {senderUser.LastName}",
                SenderEmail = senderUser.Email,
                SenderProfilePictureUrl = senderUser.ProfileImageUrl

            };

            return View(model);
        }






        // Mesaj silme (POST önerilir)
        [HttpPost]
        public async Task<IActionResult> DeleteBox(List<int> selectedMessageIds)
        {
            if (selectedMessageIds == null || selectedMessageIds.Count == 0)
            {
                TempData["SuccessMessage"] = "Hiçbir mesaj seçilmedi.";
                return RedirectToAction("SendBox");
            }

            var messagesToDelete = await _context.Emails
                .Where(m => selectedMessageIds.Contains(m.MessageId))
                .ToListAsync();

            // Mesajları silmek yerine IsDeleted alanını 1 yapıyoruz
            foreach (var message in messagesToDelete)
            {
                message.IsDeleted = true;
            }

            // Değişiklikleri veritabanına kaydediyoruz
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Seçilen mesajlar başarıyla çöp kutusuna taşındı.";
            return RedirectToAction("SendBox");
        }




        // Seçilen mesajları okundu olarak işaretle
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Read(List<int> messageId)
        {
            if (messageId != null && messageId.Any())
            {
                var messages = await _context.Emails
                    .Where(m => messageId.Contains(m.MessageId))
                    .ToListAsync();

                foreach (var msg in messages)
                {
                    msg.IsRead = true;
                }

                await _context.SaveChangesAsync();
                TempData["MessageStatusChanged"] = "Seçilen mesajlar okundu olarak işaretlendi.";
            }
            else
            {
                TempData["MessageStatusChanged"] = "Lütfen en az bir mesaj seçin.";
            }

            return RedirectToAction("Inbox");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MoveToTrashMessage(List<int> messageId)
        {
            if (messageId == null || !messageId.Any())
            {
                TempData["MessageStatusChanged"] = "Lütfen en az bir mesaj seçin.";
                return RedirectToAction("Inbox");
            }

            var messages = await _context.Emails
                .Where(x => messageId.Contains(x.MessageId))
                .ToListAsync();

            foreach (var item in messages)
            {
                item.IsDeleted = true;
            }

            await _context.SaveChangesAsync();

            TempData["MessageStatusChanged"] = "Seçilen mesajlar çöp kutusuna taşındı.";

            return RedirectToAction("Inbox");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSentMessages(List<int> selectedMessageIds)
        {
            if (selectedMessageIds == null || selectedMessageIds.Count == 0)
            {
                TempData["SuccessMessage"] = "Hiçbir mesaj seçilmedi.";
                return RedirectToAction("SendBox");
            }

            var messagesToDelete = await _context.Emails
                .Where(m => selectedMessageIds.Contains(m.MessageId))
                .ToListAsync();

            // Mesajları silmek yerine IsDeleted alanını 1 yapıyoruz
            foreach (var message in messagesToDelete)
            {
                message.IsDeleted = true;
            }

            // Değişiklikleri veritabanına kaydediyoruz
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "Seçilen mesajlar başarıyla çöp kutusuna taşındı.";
            return RedirectToAction("SendBox");
        }


        // GET: MailChat/TrashBox
        public IActionResult TrashBox(string search)
        {
            // Silinen mesajları getir (örnek: IsDeleted=true gibi bir filter olabilir)
            var emails = _context.Emails
                .Where(e => e.IsDeleted)  // veya silinen mesajları filtrele
                .AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                emails = emails.Where(e => e.Subject.Contains(search) || e.SenderEmail.Contains(search));
            }

            var model = emails.ToList();

            return View(model);
        }


       
    }
}
