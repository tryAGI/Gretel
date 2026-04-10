#nullable enable

namespace Gretel
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get workflow run task logs<br/>
        /// Get log upload URL for a specific workflow task.
        /// </summary>
        /// <param name="workflowRunId"></param>
        /// <param name="actionName"></param>
        /// <param name="workflowTaskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.LogUploadUrl> GetWorkflowRunTaskLogsAsync(
            string workflowRunId,
            string actionName,
            string workflowTaskId,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}