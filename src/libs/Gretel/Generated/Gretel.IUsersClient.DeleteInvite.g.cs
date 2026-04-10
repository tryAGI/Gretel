#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete invite<br/>
        /// Delete or reject a pending invite.
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> DeleteInviteAsync(
            string inviteId,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}