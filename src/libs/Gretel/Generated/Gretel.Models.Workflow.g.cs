
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Workflow
    {
        /// <summary>
        /// Workflow unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Workflow name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Parent project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Workflow configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Runner mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_mode")]
        public string? RunnerMode { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow" /> class.
        /// </summary>
        /// <param name="id">
        /// Workflow unique identifier
        /// </param>
        /// <param name="name">
        /// Workflow name
        /// </param>
        /// <param name="projectId">
        /// Parent project ID
        /// </param>
        /// <param name="config">
        /// Workflow configuration
        /// </param>
        /// <param name="runnerMode">
        /// Runner mode
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Workflow(
            string? id,
            string? name,
            string? projectId,
            object? config,
            string? runnerMode,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.ProjectId = projectId;
            this.Config = config;
            this.RunnerMode = runnerMode;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workflow" /> class.
        /// </summary>
        public Workflow()
        {
        }
    }
}