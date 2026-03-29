#nullable enable

namespace Gretel
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get logs<br/>
        /// Retrieve logs with optional filtering.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="pageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.LogList> GetLogsAsync(
            string? query = default,
            int? limit = default,
            string? pageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}