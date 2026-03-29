
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Artifact
    {
        /// <summary>
        /// Artifact key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Artifact filename
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Pre-signed upload URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        /// <param name="key">
        /// Artifact key
        /// </param>
        /// <param name="filename">
        /// Artifact filename
        /// </param>
        /// <param name="uploadUrl">
        /// Pre-signed upload URL
        /// </param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Artifact(
            string? key,
            string? filename,
            string? uploadUrl,
            global::System.DateTime? createdAt)
        {
            this.Key = key;
            this.Filename = filename;
            this.UploadUrl = uploadUrl;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Artifact" /> class.
        /// </summary>
        public Artifact()
        {
        }
    }
}