using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace RustHub.Components.Blocks.CardBlock
{
    public class CardBlockComponent : AsyncBlockComponent<CardBlock>
    {
        protected override async Task<IViewComponentResult> InvokeComponentAsync(CardBlock currentBlock)
        {
            return await Task.FromResult(View("~/Components/Blocks/CardBlock/CardBlock.cshtml", currentBlock));
        }
    }
}
