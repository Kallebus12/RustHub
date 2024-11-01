using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc.Html;
using EPiServer.Web.Routing;
using System.Text;
using RustHub.Business.CMS.Extensions;

namespace RustHub.Components.Frameworks.NavigationMenu
{
    public static class NavigationHelper
    {
        public static IHtmlContent MenuList(
        this IHtmlHelper helper,
        ContentReference rootLink,
        Func<MenuItem, HelperResult> itemTemplate = null,
        bool includeRoot = false,
        bool requireVisibleInMenu = true,
        bool requirePageTemplate = true)
        {
            itemTemplate ??= GetDefaultItemTemplate(helper);
            var currentContentLink = helper.ViewContext.HttpContext.GetContentLink();
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

            IEnumerable<PageData> filter(IEnumerable<PageData> pages)
                => pages.FilterForDisplay(requirePageTemplate, requireVisibleInMenu);

            var pagePath = contentLoader.GetAncestors(currentContentLink)
                .Reverse()
                .Select(x => x.ContentLink)
                .SkipWhile(x => !x.CompareToIgnoreWorkID(rootLink))
                .ToList();

            var menuItems = contentLoader.GetChildren<PageData>(rootLink)
                .FilterForDisplay(requirePageTemplate, requireVisibleInMenu)
                .Select(x => CreateMenuItem(x, currentContentLink, pagePath, contentLoader, filter))
                .ToList();

            if (includeRoot)
            {
                menuItems.Insert(0, CreateMenuItem(contentLoader.Get<PageData>(rootLink), currentContentLink, pagePath, contentLoader, filter));
            }

            var buffer = new StringBuilder();
            var writer = new StringWriter(buffer);
            foreach (var menuItem in menuItems)
            {
                itemTemplate(menuItem).WriteTo(writer, HtmlEncoder.Default);
            }

            return new HtmlString(buffer.ToString());
        }

        private static MenuItem CreateMenuItem(PageData page, ContentReference currentContentLink, List<ContentReference> pagePath, IContentLoader contentLoader, Func<IEnumerable<PageData>, IEnumerable<PageData>> filter)
        {
            var menuItem = new MenuItem(page)
            {
                Selected = page.ContentLink.CompareToIgnoreWorkID(currentContentLink) ||
                           pagePath.Contains(page.ContentLink),

                HasChildren = new Lazy<bool>(() => filter(contentLoader.GetChildren<PageData>(page.ContentLink)).Any())
            };

            return menuItem;
        }

        private static Func<MenuItem, HelperResult> GetDefaultItemTemplate(IHtmlHelper helper)
        {
            return x => new HelperResult(writer =>
            {
                helper.PageLink(x.Page).WriteTo(writer, HtmlEncoder.Default);
                return Task.CompletedTask;
            });
        }

        public class MenuItem
        {
            public MenuItem(PageData page)
            {
                Page = page;
            }

            public PageData Page { get; set; }

            public bool Selected { get; set; }

            public Lazy<bool> HasChildren { get; set; }
        }
    }
}
