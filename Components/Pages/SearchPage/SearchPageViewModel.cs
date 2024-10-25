using EPiServer.Find.UnifiedSearch;

namespace RustHub.Components.Pages.SearchPage
{
    public class SearchPageViewModel
    {
        public string SearchQuery
        {
            get;
            set;
        }
        public UnifiedSearchResults Results
        {
            get;
            set;
        }
    }
}
