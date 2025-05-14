using Microsoft.AspNetCore.Mvc;

namespace IdentityMailChatApp.Web.ViewComponents
{
    public class MailChatScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
