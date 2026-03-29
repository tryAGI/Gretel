#nullable enable

namespace Gretel
{
    public partial interface IClustersClient
    {
        /// <summary>
        /// List clusters<br/>
        /// List available compute clusters.
        /// </summary>
        /// <param name="ownedOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ClusterList> ListClustersAsync(
            bool? ownedOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}