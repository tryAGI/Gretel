#nullable enable

namespace Gretel
{
    public partial interface IConnectionsClient
    {
        /// <summary>
        /// Update connection<br/>
        /// Update a connection.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Connection> UpdateConnectionAsync(
            string connectionId,

            global::Gretel.UpdateConnectionRequest request,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update connection<br/>
        /// Update a connection.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="name"></param>
        /// <param name="credentials"></param>
        /// <param name="encryptedCredentials"></param>
        /// <param name="config"></param>
        /// <param name="connectionTargetType"></param>
        /// <param name="authStrategy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Connection> UpdateConnectionAsync(
            string connectionId,
            string? name = default,
            object? credentials = default,
            object? encryptedCredentials = default,
            object? config = default,
            string? connectionTargetType = default,
            string? authStrategy = default,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}