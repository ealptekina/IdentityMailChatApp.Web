using IdentityMailChatApp.Web.Entities;
using IdentityMailChatApp.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class ProfileController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public ProfileController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> ProfileDetail()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return RedirectToAction("Login", "Account");
        }

        var model = new ProfileViewModel
        {
            Firstname = user.FirstName,
            Lastname = user.LastName,
            City = user.City,
            PhoneNumber = user.PhoneNumber,
            ProfileImageUrl = user.ProfileImageUrl,
            About = user.About,
            Email = user.Email
        };

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> UpdateProfile()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToAction("Login", "Account");
        }

        var model = new ProfileViewModel
        {
            Firstname = user.FirstName,
            Lastname = user.LastName,
            City = user.City,
            PhoneNumber = user.PhoneNumber,
            ProfileImageUrl = user.ProfileImageUrl,
            About = user.About,
            Email = user.Email
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateProfile(ProfileViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToAction("Login", "Account");
        }

        // Güncellemeleri yap
        user.City = model.City;
        user.PhoneNumber = model.PhoneNumber;
        user.ProfileImageUrl = model.ProfileImageUrl;
        user.About = model.About;
        user.Email = model.Email;

        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded)
        {
            TempData["ProfileUpdated"] = "Profiliniz başarıyla güncellendi!";
            return RedirectToAction("ProfileDetail"); // Başarılı güncelleme sonrası ProfileDetail sayfasına yönlendir
        }

        // Hataları döndür
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return View(model);
    }
}
