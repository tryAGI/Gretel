#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project<br/>
        /// Get project details by ID or name.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Project> GetProjectAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}