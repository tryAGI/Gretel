
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWorkflowRunRequest
    {
        /// <summary>
        /// Workflow ID to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Optional config overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Optional config text overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_text")]
        public string? ConfigText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRunRequest" /> class.
        /// </summary>
        /// <param name="workflowId">
        /// Workflow ID to run
        /// </param>
        /// <param name="config">
        /// Optional config overrides
        /// </param>
        /// <param name="configText">
        /// Optional config text overrides
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowRunRequest(
            string workflowId,
            object? config,
            string? configText)
        {
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.Config = config;
            this.ConfigText = configText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRunRequest" /> class.
        /// </summary>
        public CreateWorkflowRunRequest()
        {
        }
    }
}