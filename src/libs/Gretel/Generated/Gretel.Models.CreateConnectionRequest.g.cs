
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectionRequest
    {
        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Connection type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Connection name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public object? Credentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_credentials")]
        public object? EncryptedCredentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectionRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Project ID
        /// </param>
        /// <param name="type">
        /// Connection type
        /// </param>
        /// <param name="name">
        /// Connection name
        /// </param>
        /// <param name="credentials"></param>
        /// <param name="encryptedCredentials"></param>
        /// <param name="config"></param>
        /// <param name="connectionTargetType"></param>
        /// <param name="authStrategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConnectionRequest(
            string projectId,
            string type,
            string name,
            object? credentials,
            object? encryptedCredentials,
            object? config,
            string? connectionTargetType,
            string? authStrategy)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Credentials = credentials;
            this.EncryptedCredentials = encryptedCredentials;
            this.Config = config;
            this.ConnectionTargetType = connectionTargetType;
            this.AuthStrategy = authStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectionRequest" /> class.
        /// </summary>
        public CreateConnectionRequest()
        {
        }
    }
}