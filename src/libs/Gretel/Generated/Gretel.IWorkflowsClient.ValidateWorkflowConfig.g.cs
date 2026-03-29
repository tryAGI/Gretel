#nullable enable

namespace Gretel
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Validate workflow config<br/>
        /// Validate a complete workflow configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ValidationResult> ValidateWorkflowConfigAsync(

            global::Gretel.ValidateWorkflowConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate workflow config<br/>
        /// Validate a complete workflow configuration.
        /// </summary>
        /// <param name="config">
        /// Workflow configuration to validate
        /// </param>
        /// <param name="runnerMode">
        /// Runner mode to validate against
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.ValidationResult> ValidateWorkflowConfigAsync(
            object? config = default,
            string? runnerMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}