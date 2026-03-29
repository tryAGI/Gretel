
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_mode")]
        public string? RunnerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="runnerMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequest(
            string? displayName,
            string? description,
            string? runnerMode)
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.RunnerMode = runnerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest" /> class.
        /// </summary>
        public UpdateProjectRequest()
        {
        }
    }
}