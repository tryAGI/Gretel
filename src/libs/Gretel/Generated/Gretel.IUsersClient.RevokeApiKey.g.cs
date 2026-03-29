#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Revoke API key<br/>
        /// Revoke the authenticated user's API key.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> RevokeApiKeyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}