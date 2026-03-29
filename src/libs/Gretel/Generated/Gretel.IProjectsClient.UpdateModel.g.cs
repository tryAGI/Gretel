#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update model<br/>
        /// Update model status or configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Model> UpdateModelAsync(
            string projectId,
            string modelId,

            global::Gretel.UpdateModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update model<br/>
        /// Update model status or configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="status">
        /// New model status
        /// </param>
        /// <param name="name">
        /// New model name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Model> UpdateModelAsync(
            string projectId,
            string modelId,
            string? status = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}