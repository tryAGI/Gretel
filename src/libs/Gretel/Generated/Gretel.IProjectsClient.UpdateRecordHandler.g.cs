#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update record handler<br/>
        /// Update record handler status (e.g., cancel).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="handlerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.RecordHandler> UpdateRecordHandlerAsync(
            string projectId,
            string modelId,
            string handlerId,

            global::Gretel.UpdateRecordHandlerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update record handler<br/>
        /// Update record handler status (e.g., cancel).
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="handlerId"></param>
        /// <param name="status">
        /// New handler status (e.g., cancelled)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.RecordHandler> UpdateRecordHandlerAsync(
            string projectId,
            string modelId,
            string handlerId,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}