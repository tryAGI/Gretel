#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Get workflow task<br/>
        /// Get workflow task details.
        /// </summary>
        /// <param name="workflowTaskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.WorkflowTask> GetWorkflowTaskAsync(
            string workflowTaskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}