#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Search workflows<br/>
        /// Search workflows with filters.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="skip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.WorkflowList> SearchWorkflowsAsync(
            string? query = default,
            string? sort = default,
            int? limit = default,
            int? skip = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}