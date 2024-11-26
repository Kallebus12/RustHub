using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace RustHub.Components.Pages.LoginPage
{
    [ContentType(DisplayName = "Login Page", GUID = "6ba489b6-07b7-4569-bda0-719204628e2e", Description = "Page for user login")]
    public class LoginPage : PageData
    {
        [Display(Name = "Page Title", Description = "Title of the page", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Title { get; set; }
    }

}
