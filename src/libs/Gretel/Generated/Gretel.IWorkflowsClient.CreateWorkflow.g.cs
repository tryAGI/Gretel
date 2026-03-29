#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Create workflow<br/>
        /// Create a new workflow for automated data generation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Workflow> CreateWorkflowAsync(

            global::Gretel.CreateWorkflowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create workflow<br/>
        /// Create a new workflow for automated data generation.
        /// </summary>
        /// <param name="projectId">
        /// Project ID to create workflow in
        /// </param>
        /// <param name="name">
        /// Workflow name
        /// </param>
        /// <param name="config">
        /// Workflow configuration
        /// </param>
        /// <param name="configText">
        /// Workflow configuration as text
        /// </param>
        /// <param name="runnerMode">
        /// Runner mode for workflow execution
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Workflow> CreateWorkflowAsync(
            string projectId,
            string name,
            object? config = default,
            string? configText = default,
            global::Gretel.CreateWorkflowRequestRunnerMode? runnerMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}