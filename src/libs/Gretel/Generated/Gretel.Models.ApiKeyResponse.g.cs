
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyResponse
    {
        /// <summary>
        /// The generated API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponse" /> class.
        /// </summary>
        /// <param name="key">
        /// The generated API key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKeyResponse(
            string? key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponse" /> class.
        /// </summary>
        public ApiKeyResponse()
        {
        }
    }
}