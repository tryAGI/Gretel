#nullable enable

namespace Gretel
{
    public partial interface IConnectionsClient
    {
        /// <summary>
        /// Get connection<br/>
        /// Get connection details.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Connection> GetConnectionAsync(
            string connectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}