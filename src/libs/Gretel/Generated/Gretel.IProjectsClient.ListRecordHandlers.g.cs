#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List record handlers<br/>
        /// List all record handlers for a model.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="status"></param>
        /// <param name="sortBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.RecordHandlerList> ListRecordHandlersAsync(
            string projectId,
            string modelId,
            global::Gretel.ListRecordHandlersStatus? status = default,
            global::Gretel.ListRecordHandlersSortBy? sortBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}