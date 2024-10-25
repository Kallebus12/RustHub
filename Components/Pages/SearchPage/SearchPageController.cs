using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Find.Framework;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using RustHub.Components.Pages.BaseClasses;

namespace RustHub.Components.Pages.SearchPage
{
    public class SearchPageController : PageController<SearchPage>
    {
        public IActionResult Index(SearchPage currentPage, string query)
        {
            
            var composedViewModel = new ComposedPageViewModel<SearchPage, SearchPageViewModel>
            {
                page = currentPage,
                viewModel = new SearchPageViewModel()
            };

            if (String.IsNullOrEmpty(query)) {
                return View("~/Components/Pages/SearchPage/Index.cshtml", composedViewModel);
            }

            var unifiedSearch = SearchClient.Instance.UnifiedSearchFor(query);

            composedViewModel.viewModel.Results = unifiedSearch.GetResult();
            composedViewModel.viewModel.SearchQuery = query;

            return View("~/Components/Pages/SearchPage/Index.cshtml", composedViewModel);
        }
    }
}
