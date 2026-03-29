#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Delete workflow<br/>
        /// Delete a workflow.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.DeleteResponse> DeleteWorkflowAsync(
            string workflowId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}