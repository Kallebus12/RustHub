using EPiServer.Framework.DataAnnotations;

namespace RustHub.Components.Features.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "a17c4a7e-ad38-475b-9ef9-2e5b343fb5c2", Description = "Used for images of different file formats.")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile: ImageData
    {
    }
}
