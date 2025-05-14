using Microsoft.AspNetCore.Mvc;

namespace IdentityMailChatApp.Web.ViewComponents
{
    public class MailChatHeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
