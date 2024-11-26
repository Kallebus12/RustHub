using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using RustHub.Components.Services;

namespace RustHub.Components.Pages.LoginPage
{
    public class LoginPageController : PageController<LoginPage>
    {
        private readonly AuthService _authService;

        public LoginPageController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Index(LoginPage currentPage)
        {
            return View("~/Components/Pages/LoginPage/Index.cshtml", currentPage);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = await _authService.AuthenticateUserAsync(username, password);
            if (user != null)
            {
                // Handle successful login (e.g., set session or cookie)
                HttpContext.Session.SetString("UserId", user.Id);
                return RedirectToAction("Index", "StartPage");
            }

            ModelState.AddModelError("", "Invalid login credentials.");
            return View("~/Components/Pages/LoginPage/Index.cshtml");
        }
    }
}
