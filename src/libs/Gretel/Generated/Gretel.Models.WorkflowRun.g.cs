
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRun
    {
        /// <summary>
        /// Workflow run unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Parent workflow ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Current run status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gretel.JsonConverters.WorkflowRunStatusJsonConverter))]
        public global::Gretel.WorkflowRunStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_msg")]
        public string? ErrorMsg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Workflow run unique identifier
        /// </param>
        /// <param name="workflowId">
        /// Parent workflow ID
        /// </param>
        /// <param name="status">
        /// Current run status
        /// </param>
        /// <param name="config"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="errorMsg"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRun(
            string? id,
            string? workflowId,
            global::Gretel.WorkflowRunStatus? status,
            object? config,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? completedAt,
            string? errorMsg)
        {
            this.Id = id;
            this.WorkflowId = workflowId;
            this.Status = status;
            this.Config = config;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CompletedAt = completedAt;
            this.ErrorMsg = errorMsg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRun" /> class.
        /// </summary>
        public WorkflowRun()
        {
        }
    }
}