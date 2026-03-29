
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectRequest
    {
        /// <summary>
        /// Display name for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// URL-safe project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Project description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default runner mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gretel.JsonConverters.CreateProjectRequestRunnerModeJsonConverter))]
        public global::Gretel.CreateProjectRequestRunnerMode? RunnerMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name for the project
        /// </param>
        /// <param name="name">
        /// URL-safe project name
        /// </param>
        /// <param name="description">
        /// Project description
        /// </param>
        /// <param name="runnerMode">
        /// Default runner mode
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectRequest(
            string displayName,
            string? name,
            string? description,
            global::Gretel.CreateProjectRequestRunnerMode? runnerMode)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Name = name;
            this.Description = description;
            this.RunnerMode = runnerMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectRequest" /> class.
        /// </summary>
        public CreateProjectRequest()
        {
        }
    }
}