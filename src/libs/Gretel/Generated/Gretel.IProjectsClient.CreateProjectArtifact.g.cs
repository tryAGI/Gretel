#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create project artifact<br/>
        /// Upload an artifact to a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Artifact> CreateProjectArtifactAsync(
            string projectId,

            global::Gretel.CreateArtifactRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project artifact<br/>
        /// Upload an artifact to a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filename">
        /// Name of the file to upload
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Artifact> CreateProjectArtifactAsync(
            string projectId,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}