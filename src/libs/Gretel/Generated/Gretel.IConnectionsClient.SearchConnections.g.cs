#nullable enable

namespace Gretel
{
    public partial interface IConnectionsClient
    {
        /// <summary>
        /// Search connections<br/>
        /// Search connections with filters.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ConnectionList> SearchConnectionsAsync(
            string? query = default,
            string? sort = default,
            int? limit = default,
            int? skip = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}