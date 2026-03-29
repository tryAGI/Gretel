
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Connection
    {
        /// <summary>
        /// Connection unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Connection type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Connection name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Connection configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Connection credentials (only when explicitly requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public object? Credentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_target_type")]
        public string? ConnectionTargetType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_strategy")]
        public string? AuthStrategy { get; set; }

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
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="id">
        /// Connection unique identifier
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="type">
        /// Connection type
        /// </param>
        /// <param name="name">
        /// Connection name
        /// </param>
        /// <param name="config">
        /// Connection configuration
        /// </param>
        /// <param name="credentials">
        /// Connection credentials (only when explicitly requested)
        /// </param>
        /// <param name="connectionTargetType"></param>
        /// <param name="authStrategy"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Connection(
            string? id,
            string? projectId,
            string? type,
            string? name,
            object? config,
            object? credentials,
            string? connectionTargetType,
            string? authStrategy,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Type = type;
            this.Name = name;
            this.Config = config;
            this.Credentials = credentials;
            this.ConnectionTargetType = connectionTargetType;
            this.AuthStrategy = authStrategy;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        public Connection()
        {
        }
    }
}