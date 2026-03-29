#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// List workflows<br/>
        /// List all workflows.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.WorkflowList> ListWorkflowsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}