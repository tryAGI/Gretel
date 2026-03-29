#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Remove team member<br/>
        /// Remove a member from your team.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> RemoveTeamMemberAsync(

            global::Gretel.TeamInviteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove team member<br/>
        /// Remove a member from your team.
        /// </summary>
        /// <param name="domainGuid">
        /// Team domain GUID
        /// </param>
        /// <param name="userEmail">
        /// Email of the user to invite or remove
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> RemoveTeamMemberAsync(
            string domainGuid,
            string userEmail,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}