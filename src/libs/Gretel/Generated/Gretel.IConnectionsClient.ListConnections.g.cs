#nullable enable

namespace Gretel
{
    public partial interface IConnectionsClient
    {
        /// <summary>
        /// List connections<br/>
        /// List all connections.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ConnectionList> ListConnectionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}