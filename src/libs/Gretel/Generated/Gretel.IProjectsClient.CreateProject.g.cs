#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create project<br/>
        /// Create a new Gretel project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Project> CreateProjectAsync(

            global::Gretel.CreateProjectRequest request,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project<br/>
        /// Create a new Gretel project.
        /// </summary>
        /// <param name="displayName">
        /// Display name for the project
        /// </param>
        /// <param name="name">
        /// URL-safe project name
        /// </param>
        /// <param name="description">
        /// Project description
        /// </param>
        /// <param name="runnerMode">
        /// Default runner mode
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Project> CreateProjectAsync(
            string displayName,
            string? name = default,
            string? description = default,
            global::Gretel.CreateProjectRequestRunnerMode? runnerMode = default,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}