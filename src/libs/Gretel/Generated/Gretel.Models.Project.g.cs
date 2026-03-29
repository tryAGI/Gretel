
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// Unique project identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Project name (URL-safe slug)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Human-readable project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Project description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default runner mode
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
        /// Project owner user ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Gretel.Member>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="uid">
        /// Unique project identifier
        /// </param>
        /// <param name="name">
        /// Project name (URL-safe slug)
        /// </param>
        /// <param name="displayName">
        /// Human-readable project name
        /// </param>
        /// <param name="description">
        /// Project description
        /// </param>
        /// <param name="runnerMode">
        /// Default runner mode
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="owner">
        /// Project owner user ID
        /// </param>
        /// <param name="members"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Project(
            string? uid,
            string? name,
            string? displayName,
            string? description,
            string? runnerMode,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? owner,
            global::System.Collections.Generic.IList<global::Gretel.Member>? members)
        {
            this.Uid = uid;
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.RunnerMode = runnerMode;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Owner = owner;
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }
    }
}