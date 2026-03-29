
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidateWorkflowConfigRequest
    {
        /// <summary>
        /// Workflow configuration to validate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Runner mode to validate against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_mode")]
        public string? RunnerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateWorkflowConfigRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Workflow configuration to validate
        /// </param>
        /// <param name="runnerMode">
        /// Runner mode to validate against
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidateWorkflowConfigRequest(
            object? config,
            string? runnerMode)
        {
            this.Config = config;
            this.RunnerMode = runnerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateWorkflowConfigRequest" /> class.
        /// </summary>
        public ValidateWorkflowConfigRequest()
        {
        }
    }
}