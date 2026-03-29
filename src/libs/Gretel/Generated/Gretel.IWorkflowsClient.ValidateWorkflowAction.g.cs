#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Validate workflow action<br/>
        /// Validate a workflow action configuration.
        /// </summary>
        /// <param name="runnerMode"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ValidationResult> ValidateWorkflowActionAsync(

            object request,
            string? runnerMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate workflow action<br/>
        /// Validate a workflow action configuration.
        /// </summary>
        /// <param name="runnerMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ValidationResult> ValidateWorkflowActionAsync(
            string? runnerMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}