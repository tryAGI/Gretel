
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Gretel.LogEntry>? Data { get; set; }

        /// <summary>
        /// Token for next page of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogList" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="nextPageToken">
        /// Token for next page of results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogList(
            global::System.Collections.Generic.IList<global::Gretel.LogEntry>? data,
            string? nextPageToken)
        {
            this.Data = data;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogList" /> class.
        /// </summary>
        public LogList()
        {
        }
    }
}