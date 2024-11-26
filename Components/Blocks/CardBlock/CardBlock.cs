using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace RustHub.Components.Blocks.CardBlock
{
    [ContentType(DisplayName = "Card Block", GUID = "9f268bb9-f64f-4832-bb32-708bc46488a6", Description = "Card Block with customizable fields")]
    public class CardBlock : BlockData
    {
        [Display(Name = "Title", Order = 10)]
        public virtual string Title { get; set; }

        [Display(Name = "Text", Order = 20)]
        public virtual XhtmlString Text { get; set; }

        [Display(Name = "Image", Order = 30)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(Name = "Icon Class", Order = 40, Description = "Specify the Font Awesome icon class")]
        public virtual string IconClass { get; set; }

        [Display(Name = "Link", Order = 50, Description = "URL to navigate to when the image is clicked")]
        public virtual Url Link { get; set; }
    }
}
