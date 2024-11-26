using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using RustHub.Components.Services;
using RustHub.Components.Shared.Models;

namespace RustHub.Components.Pages.RegisterPage
{
    public class RegisterPageController : PageController<RegisterPage>
    {
        private readonly AuthService _authService;

        public RegisterPageController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Index(RegisterPage currentPage)
        {
            return View("~/Components/Pages/RegisterPage/Index.cshtml", new UserModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Components/Pages/RegisterPage/Index.cshtml", model);
            }

            var success = await _authService.RegisterUserAsync(model.Username, model.Password);
            if (!success)
            {
                ModelState.AddModelError("", "An error occurred during registration. Please try again.");
                return View("~/Components/Pages/RegisterPage/Index.cshtml", model);
            }

            return RedirectToAction("Index", "LoginPage");
        }
    }
}
