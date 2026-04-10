#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Get workflow<br/>
        /// Get workflow details.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Workflow> GetWorkflowAsync(
            string workflowId,
            global::Gretel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}