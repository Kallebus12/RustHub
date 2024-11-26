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
            var startPage = _contentLoader.Get<StartPage>(ContentReference.StartPage);
            var menuItems = GetMenuItems(startPage.ContentLink).ToList();

            // Check if the user is authenticated
            var isAuthenticated = HttpContext.User.Identity.IsAuthenticated;

            if (!isAuthenticated)
            {
                // Add LoginPage and RegisterPage if user is not logged in
                if (startPage.LoginPage != null)
                {
                    var loginPage = _contentLoader.Get<PageData>(startPage.LoginPage);
                    menuItems.Add(loginPage);
                }

                if (startPage.RegisterPage != null)
                {
                    var registerPage = _contentLoader.Get<PageData>(startPage.RegisterPage);
                    menuItems.Add(registerPage);
                }
            }
            else
            {
                // Optionally, add a Logout link
                menuItems.Add(new PageData
                {
                    Name = "Logout",
                    LinkURL = "/Account/Logout" // Update this if your logout URL is different
                });
            }

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
