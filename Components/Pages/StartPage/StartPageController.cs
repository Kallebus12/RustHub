using Microsoft.AspNetCore.Mvc;
using EPiServer.Web.Mvc;

namespace RustHub.Components.Pages.StartPage
{
    public class StartPageController : PageController<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            return View("~/Components/Pages/StartPage/Index.cshtml", currentPage);
        }

    }
}
