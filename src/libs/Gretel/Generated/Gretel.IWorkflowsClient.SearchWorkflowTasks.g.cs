#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Search workflow tasks<br/>
        /// Search workflow tasks with filters.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.WorkflowTaskList> SearchWorkflowTasksAsync(
            string? query = default,
            int? limit = default,
            int? skip = default,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}