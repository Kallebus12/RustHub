namespace RustHub.Components.Pages.BaseClasses
{
    public class ComposedPageViewModel <TPage, TViewModel> where TPage : PageData
    {
        public TPage page { get; set; }
        public TViewModel viewModel { get; set; }
    }
}
