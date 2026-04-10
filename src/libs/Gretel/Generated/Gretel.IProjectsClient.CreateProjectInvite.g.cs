#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create or update project invite<br/>
        /// Invite a user to a project or update an existing membership.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Invite> CreateProjectInviteAsync(
            string projectId,

            global::Gretel.CreateInviteRequest request,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update project invite<br/>
        /// Invite a user to a project or update an existing membership.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="email">
        /// Email address of the user to invite
        /// </param>
        /// <param name="level">
        /// Permission level (1=viewer, 2=member, 3=admin)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Invite> CreateProjectInviteAsync(
            string projectId,
            string email,
            int level,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}