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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> DeleteProjectArtifactAsync(
            string projectId,
            string key,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}