using EPiServer;
using EPiServer.Core;
using Microsoft.AspNetCore.Mvc;
using RustHub.Components.Frameworks.NavigationMenu;
using RustHub.Components.Pages.StartPage;
using System.Collections.Generic;
using System.Linq;

namespace RustHub.Components.Frameworks.NavigationMenu
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IContentLoader _contentLoader;

        public MenuViewComponent(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public IViewComponentResult Invoke()
        {
            // Load the start page (or the root page for the menu)
            var startPage = _contentLoader.Get<StartPage>(ContentReference.StartPage);
            var menuItems = GetMenuItems(startPage.ContentLink);

            var viewModel = new NavigationModel
            {
                Items = menuItems,
            };

            return View("~/Components/Frameworks/NavigationMenu/Default.cshtml", viewModel);
        }

        private IEnumerable<PageData> GetMenuItems(ContentReference rootLink)
        {
            var menuItems = _contentLoader.GetChildren<PageData>(rootLink).Where(x => x.VisibleInMenu);
            return menuItems;
        }
    }
}
