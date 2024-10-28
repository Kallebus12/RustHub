using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace RustHub.Components.Blocks.VideoBlock
{
    public class VideoBlockController : AsyncBlockComponent<VideoBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(VideoBlock currentBlock)
        {
            return await Task.FromResult(View("~/Components/Blocks/VideoBlock/VideoBlock.cshtml", currentBlock));
        }
    }
}
