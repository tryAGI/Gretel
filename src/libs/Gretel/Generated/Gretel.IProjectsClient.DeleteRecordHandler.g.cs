#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete record handler<br/>
        /// Delete a record handler.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="handlerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> DeleteRecordHandlerAsync(
            string projectId,
            string modelId,
            string handlerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}