#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get model<br/>
        /// Get model details including status and configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Model> GetModelAsync(
            string projectId,
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}