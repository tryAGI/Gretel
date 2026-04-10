#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Download project artifact<br/>
        /// Get a download URL for a project artifact.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ArtifactDownload> DownloadProjectArtifactAsync(
            string projectId,
            string? key = default,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}