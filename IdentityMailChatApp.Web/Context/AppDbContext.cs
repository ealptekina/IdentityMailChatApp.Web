using IdentityMailChatApp.Web.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityMailChatApp.Web.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-IMEIVGC\\SQLEXPRESS;initial Catalog=EmailChatApp;integrated security=true;trust server certificate=true");
        }
        public DbSet<Email> Emails { get; set; }
    }
}
