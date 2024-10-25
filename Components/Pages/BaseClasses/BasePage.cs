using System.ComponentModel.DataAnnotations;

namespace RustHub.Components.Pages.BaseClasses
{
    public abstract class BasePage : PageData
    {
        [Display(Name = "Meta Title")]
        public virtual string MetaTitle { get; set; }

        [Display(Name = "Meta Description")]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "Meta Keywords")]
        public virtual string MetaKeywords { get; set; }

        [Display(Name = "Heading", Order = 10)]
        public virtual string Heading { get; set; }
    }
}
