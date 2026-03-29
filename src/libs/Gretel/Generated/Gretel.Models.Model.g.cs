
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Model unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Type of model (e.g., ctgan, lstm, transform)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// Current model status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gretel.JsonConverters.ModelStatusJsonConverter))]
        public global::Gretel.ModelStatus? Status { get; set; }

        /// <summary>
        /// Parent project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Model configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Error message if status is error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_msg")]
        public string? ErrorMsg { get; set; }

        /// <summary>
        /// Runner mode used for training
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_mode")]
        public string? RunnerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="uid">
        /// Model unique identifier
        /// </param>
        /// <param name="name">
        /// Model name
        /// </param>
        /// <param name="modelType">
        /// Type of model (e.g., ctgan, lstm, transform)
        /// </param>
        /// <param name="status">
        /// Current model status
        /// </param>
        /// <param name="projectId">
        /// Parent project ID
        /// </param>
        /// <param name="config">
        /// Model configuration
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="errorMsg">
        /// Error message if status is error
        /// </param>
        /// <param name="runnerMode">
        /// Runner mode used for training
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string? uid,
            string? name,
            string? modelType,
            global::Gretel.ModelStatus? status,
            string? projectId,
            object? config,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? completedAt,
            string? errorMsg,
            string? runnerMode)
        {
            this.Uid = uid;
            this.Name = name;
            this.ModelType = modelType;
            this.Status = status;
            this.ProjectId = projectId;
            this.Config = config;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.ErrorMsg = errorMsg;
            this.RunnerMode = runnerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}