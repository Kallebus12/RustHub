using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace RustHub.Components.Pages.RegisterPage
{
    [ContentType(DisplayName = "Register Page", GUID = "7f254d65-7fde-4543-b120-7013594dbd00", Description = "Page for user registration")]
    public class RegisterPage : PageData
    {
        [Display(Name = "Page Title", Description = "Title of the page", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; }
    }

}
