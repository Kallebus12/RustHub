using Microsoft.AspNetCore.Mvc;
using RustHub.Components.Pages.StartPage;

namespace RustHub.Components.Frameworks.NavigationMenu
{
    public class TopNavigationViewComponent : ViewComponent
    {
        private readonly IContentLoader _contentLoader;

        public TopNavigationViewComponent(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public IViewComponentResult Invoke()
        {
            // Load the start page (or the root page for the menu)
            var startPage = _contentLoader.Get<StartPage>(ContentReference.StartPage);

            return View("~/Components/Frameworks/NavigationMenu/TopNavigation.cshtml");
        }
    }
}
