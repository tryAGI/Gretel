#nullable enable

namespace Gretel
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create API key<br/>
        /// Create a new persistent API key for the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ApiKeyResponse> CreateApiKeyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}