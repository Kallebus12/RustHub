using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace RustHub.Components.Blocks.VideoBlock
{
    [ContentType(DisplayName = "Video Block", GUID = "3f09dcd3-dd1c-4ffb-a58f-742c28982af8", Description = "A block with title, description, and a text area")]
    public class VideoBlock : BlockData
    {
        [Display(
            Name = "Title",
            Description = "The title of the block",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Description",
            Description = "A brief description",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Description { get; set; }

        [Display(
            Name = "Content",
            Description = "The main text content",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [UIHint(UIHint.Textarea)]
        public virtual string Content { get; set; }
    }
}