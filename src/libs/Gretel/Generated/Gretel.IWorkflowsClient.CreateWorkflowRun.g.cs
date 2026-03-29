#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Create workflow run<br/>
        /// Start a new run of a workflow to generate synthetic data.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.WorkflowRun> CreateWorkflowRunAsync(

            global::Gretel.CreateWorkflowRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create workflow run<br/>
        /// Start a new run of a workflow to generate synthetic data.
        /// </summary>
        /// <param name="workflowId">
        /// Workflow ID to run
        /// </param>
        /// <param name="config">
        /// Optional config overrides
        /// </param>
        /// <param name="configText">
        /// Optional config text overrides
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.WorkflowRun> CreateWorkflowRunAsync(
            string workflowId,
            object? config = default,
            string? configText = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}