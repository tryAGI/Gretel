
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWorkflowRequest
    {
        /// <summary>
        /// Project ID to create workflow in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Workflow name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Workflow configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Workflow configuration as text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_text")]
        public string? ConfigText { get; set; }

        /// <summary>
        /// Runner mode for workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gretel.JsonConverters.CreateWorkflowRequestRunnerModeJsonConverter))]
        public global::Gretel.CreateWorkflowRequestRunnerMode? RunnerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowRequest(
            string projectId,
            string name,
            object? config,
            string? configText,
            global::Gretel.CreateWorkflowRequestRunnerMode? runnerMode)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Config = config;
            this.ConfigText = configText;
            this.RunnerMode = runnerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRequest" /> class.
        /// </summary>
        public CreateWorkflowRequest()
        {
        }
    }
}