#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Update workflow config<br/>
        /// Update the configuration of a workflow.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Workflow> UpdateWorkflowConfigAsync(
            string workflowId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update workflow config<br/>
        /// Update the configuration of a workflow.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Workflow> UpdateWorkflowConfigAsync(
            string workflowId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}