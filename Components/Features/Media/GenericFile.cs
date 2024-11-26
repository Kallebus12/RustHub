using System.ComponentModel.DataAnnotations;

namespace RustHub.Components.Features.Media
{
    [ContentType(
        GUID = "01556d6c-d0f2-415b-bb52-7b59fb7ca3d7",
        DisplayName = "File")]
    public class GenericFile : MediaData
    {
        [Editable(false)]
        public virtual string? FileExtension { get; set; }
        [Editable(false)]
        public virtual int FileSize { get; set; }
    }
}
