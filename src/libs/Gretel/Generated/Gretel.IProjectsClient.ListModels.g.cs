#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List models<br/>
        /// List all models in a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit"></param>
        /// <param name="modelType"></param>
        /// <param name="sortBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ModelList> ListModelsAsync(
            string projectId,
            int? limit = default,
            string? modelType = default,
            global::Gretel.ListModelsSortBy? sortBy = default,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}