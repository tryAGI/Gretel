
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArtifactDownload
    {
        /// <summary>
        /// Pre-signed download URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Artifact key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactDownload" /> class.
        /// </summary>
        /// <param name="url">
        /// Pre-signed download URL
        /// </param>
        /// <param name="key">
        /// Artifact key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactDownload(
            string? url,
            string? key)
        {
            this.Url = url;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactDownload" /> class.
        /// </summary>
        public ArtifactDownload()
        {
        }
    }
}