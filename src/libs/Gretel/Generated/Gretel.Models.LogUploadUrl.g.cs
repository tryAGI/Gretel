
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogUploadUrl
    {
        /// <summary>
        /// Pre-signed URL for uploading logs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogUploadUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// Pre-signed URL for uploading logs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogUploadUrl(
            string? url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogUploadUrl" /> class.
        /// </summary>
        public LogUploadUrl()
        {
        }
    }
}