#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get model artifact<br/>
        /// Download a model artifact such as the trained model or report.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ArtifactDownload> GetModelArtifactAsync(
            string projectId,
            string modelId,
            global::Gretel.GetModelArtifactType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}