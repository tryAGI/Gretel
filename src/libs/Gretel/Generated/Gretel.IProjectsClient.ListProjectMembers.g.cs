#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List project members<br/>
        /// List all members of a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.MemberList> ListProjectMembersAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}