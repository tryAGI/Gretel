#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List invites<br/>
        /// List pending invites for the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.InviteList> ListInvitesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}