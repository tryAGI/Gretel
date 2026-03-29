
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateModelRequest
    {
        /// <summary>
        /// New model status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// New model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelRequest" /> class.
        /// </summary>
        /// <param name="status">
        /// New model status
        /// </param>
        /// <param name="name">
        /// New model name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateModelRequest(
            string? status,
            string? name)
        {
            this.Status = status;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelRequest" /> class.
        /// </summary>
        public UpdateModelRequest()
        {
        }
    }
}