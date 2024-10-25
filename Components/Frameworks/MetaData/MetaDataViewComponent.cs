using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using RustHub.Components.Pages.BaseClasses;

namespace RustHub.Components.Frameworks.MetaData;

public class MetaDataViewComponent : ViewComponent
{
    private readonly IPageRouteHelper _pageRouteHelper;
    private readonly IContentRepository _contentRepository;

    public MetaDataViewComponent(
        IPageRouteHelper pageRouteHelper,
        IContentRepository contentRepository)
    {
        _pageRouteHelper = pageRouteHelper;
        _contentRepository = contentRepository;
    }

    public IViewComponentResult Invoke()
    {
        var page = _pageRouteHelper.Content as BasePage;
        if (page == null)
        {
            return Content(string.Empty);
        }

        var metaData = new MetaDataViewModel
        {
            Title = page.MetaTitle ?? page.Name,
            Description = page.MetaDescription,
            Keywords = page.MetaKeywords
        };

        return View("~/Components/Frameworks/MetaData/MetaData.cshtml", metaData);
    }
}
