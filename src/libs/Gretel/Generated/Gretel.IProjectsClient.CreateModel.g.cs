#nullable enable

namespace Gretel
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create model<br/>
        /// Create a new model in a project. Models define the synthetic data generation configuration including the model type (CTGAN, LSTM, etc.) and parameters.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="runnerMode"></param>
        /// <param name="dryRun"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Gretel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Model> CreateModelAsync(
            string projectId,

            global::Gretel.CreateModelRequest request,
            global::Gretel.CreateModelRunnerMode? runnerMode = default,
            global::Gretel.CreateModelDryRun? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create model<br/>
        /// Create a new model in a project. Models define the synthetic data generation configuration including the model type (CTGAN, LSTM, etc.) and parameters.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="runnerMode"></param>
        /// <param name="dryRun"></param>
        /// <param name="schemaVersion">
        /// Configuration schema version<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="name">
        /// Model name
        /// </param>
        /// <param name="models">
        /// Array of model configurations. Each defines a model type and its parameters. Supported types include ctgan, lstm, amplify, transform, classify, and more.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Gretel.Model> CreateModelAsync(
            string projectId,
            global::Gretel.CreateModelRunnerMode? runnerMode = default,
            global::Gretel.CreateModelDryRun? dryRun = default,
            string? schemaVersion = default,
            string? name = default,
            global::System.Collections.Generic.IList<object>? models = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}