
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelRequest
    {
        /// <summary>
        /// Configuration schema version<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        public string? SchemaVersion { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Array of model configurations. Each defines a model type and its parameters. Supported types include ctgan, lstm, amplify, transform, classify, and more.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<object>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        /// <param name="schemaVersion">
        /// Configuration schema version<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="name">
        /// Model name
        /// </param>
        /// <param name="models">
        /// Array of model configurations. Each defines a model type and its parameters. Supported types include ctgan, lstm, amplify, transform, classify, and more.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelRequest(
            string? schemaVersion,
            string? name,
            global::System.Collections.Generic.IList<object>? models)
        {
            this.SchemaVersion = schemaVersion;
            this.Name = name;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        public CreateModelRequest()
        {
        }
    }
}