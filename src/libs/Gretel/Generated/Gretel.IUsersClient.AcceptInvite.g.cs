#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Accept invite<br/>
        /// Accept a pending invite.
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Invite> AcceptInviteAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}