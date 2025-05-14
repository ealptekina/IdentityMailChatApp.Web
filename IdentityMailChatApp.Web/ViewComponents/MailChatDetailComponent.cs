using Microsoft.AspNetCore.Mvc;

namespace IdentityMailChatApp.Web.ViewComponents
{
    public class MailChatDetailComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
