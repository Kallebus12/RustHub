using EPiServer.Shell.ObjectEditing;
using RustHub.Business.CMS;


using RustHub.Components.Pages.BaseClasses;
using System.ComponentModel.DataAnnotations;

namespace RustHub.Components.Pages.StartPage
{
    [ContentType(
    DisplayName = "Start Page", GUID = "45c49de5-76ae-47aa-a26b-e926dc155eec")]
    public class StartPage : BasePage
    {
        [Display(
        GroupName = SystemTabNames.Content,
        Order = 100)]
        public virtual ContentArea MainContent { get; set; }

        [Display(Name = "Sidfot - Adress", GroupName = GroupNames.Footer, Order = 3000)]
        public virtual string FooterAddress { get; set; }
    }
}
