#nullable enable

namespace Gretel
{
    public partial interface IClustersClient
    {
        /// <summary>
        /// Get cluster<br/>
        /// Get cluster details.
        /// </summary>
        /// <param name="clusterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Cluster> GetClusterAsync(
            string clusterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}