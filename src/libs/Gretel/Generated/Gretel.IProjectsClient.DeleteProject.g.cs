#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete project<br/>
        /// Delete a project and all its resources.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="dryRun"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> DeleteProjectAsync(
            string projectId,
            bool? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}