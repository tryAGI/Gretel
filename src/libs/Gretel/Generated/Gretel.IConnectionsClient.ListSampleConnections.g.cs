#nullable enable

namespace Gretel
{
    public partial interface IConnectionsClient
    {
        /// <summary>
        /// List sample connections<br/>
        /// List sample connection configurations.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ConnectionList> ListSampleConnectionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}