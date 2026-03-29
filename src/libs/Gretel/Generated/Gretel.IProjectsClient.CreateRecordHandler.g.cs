#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create record handler<br/>
        /// Create a record handler for a model to generate synthetic data records. This starts the data generation process.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.RecordHandler> CreateRecordHandlerAsync(
            string projectId,
            string modelId,

            global::Gretel.CreateRecordHandlerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create record handler<br/>
        /// Create a record handler for a model to generate synthetic data records. This starts the data generation process.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="modelId"></param>
        /// <param name="dataSource">
        /// Reference to the data source artifact
        /// </param>
        /// <param name="params">
        /// Parameters for record generation. For synthetic data, set num_records. For transforms, specify transform-specific params.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.RecordHandler> CreateRecordHandlerAsync(
            string projectId,
            string modelId,
            string? dataSource = default,
            object? @params = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}