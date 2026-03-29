#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete project membership<br/>
        /// Remove a member or cancel an invite for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="membershipId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> DeleteProjectMemberAsync(
            string projectId,
            string membershipId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}