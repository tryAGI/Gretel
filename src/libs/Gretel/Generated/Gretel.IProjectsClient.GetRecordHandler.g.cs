#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get record handler<br/>
        /// Get record handler details including status and artifacts.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="handlerId"></param>
        /// <param name="expand"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.RecordHandler> GetRecordHandlerAsync(
            string projectId,
            string modelId,
            string handlerId,
            string? expand = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}