using EPiServer.Core;

namespace GitHubDemo_1.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
