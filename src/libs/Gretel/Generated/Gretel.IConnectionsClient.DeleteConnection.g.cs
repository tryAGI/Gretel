#nullable enable

namespace Gretel
{
    public partial interface IConnectionsClient
    {
        /// <summary>
        /// Delete connection<br/>
        /// Delete a connection.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> DeleteConnectionAsync(
            string connectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}