using Microsoft.AspNetCore.Mvc;

namespace IdentityMailChatApp.Web.ViewComponents
{
    public class MailChatFooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
