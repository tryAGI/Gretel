#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete project artifact<br/>
        /// Delete a specific artifact from a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> DeleteProjectArtifactAsync(
            string projectId,
            string key,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}