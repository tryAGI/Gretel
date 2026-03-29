
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordHandler
    {
        /// <summary>
        /// Record handler unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Parent model ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Current handler status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gretel.JsonConverters.RecordHandlerStatusJsonConverter))]
        public global::Gretel.RecordHandlerStatus? Status { get; set; }

        /// <summary>
        /// Handler parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Source data reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source")]
        public string? DataSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Error message if status is error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_msg")]
        public string? ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts")]
        public global::System.Collections.Generic.IList<global::Gretel.Artifact>? Artifacts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordHandler" /> class.
        /// </summary>
        /// <param name="uid">
        /// Record handler unique identifier
        /// </param>
        /// <param name="modelId">
        /// Parent model ID
        /// </param>
        /// <param name="status">
        /// Current handler status
        /// </param>
        /// <param name="params">
        /// Handler parameters
        /// </param>
        /// <param name="dataSource">
        /// Source data reference
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="errorMsg">
        /// Error message if status is error
        /// </param>
        /// <param name="artifacts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordHandler(
            string? uid,
            string? modelId,
            global::Gretel.RecordHandlerStatus? status,
            object? @params,
            string? dataSource,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? errorMsg,
            global::System.Collections.Generic.IList<global::Gretel.Artifact>? artifacts)
        {
            this.Uid = uid;
            this.ModelId = modelId;
            this.Status = status;
            this.Params = @params;
            this.DataSource = dataSource;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.ErrorMsg = errorMsg;
            this.Artifacts = artifacts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordHandler" /> class.
        /// </summary>
        public RecordHandler()
        {
        }
    }
}