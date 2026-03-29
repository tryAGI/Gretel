#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update project<br/>
        /// Update an existing project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Project> UpdateProjectAsync(
            string projectId,

            global::Gretel.UpdateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project<br/>
        /// Update an existing project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="runnerMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Project> UpdateProjectAsync(
            string projectId,
            string? displayName = default,
            string? description = default,
            string? runnerMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}