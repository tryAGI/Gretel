
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowTask
    {
        /// <summary>
        /// Task unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run_id")]
        public string? WorkflowRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_name")]
        public string? ActionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Gretel.JsonConverters.WorkflowTaskStatusJsonConverter))]
        public global::Gretel.WorkflowTaskStatus? Status { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_msg")]
        public string? ErrorMsg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_location")]
        public string? LogLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTask" /> class.
        /// </summary>
        /// <param name="id">
        /// Task unique identifier
        /// </param>
        /// <param name="workflowRunId"></param>
        /// <param name="actionName"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="errorMsg"></param>
        /// <param name="logLocation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowTask(
            string? id,
            string? workflowRunId,
            string? actionName,
            global::Gretel.WorkflowTaskStatus? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? errorMsg,
            string? logLocation)
        {
            this.Id = id;
            this.WorkflowRunId = workflowRunId;
            this.ActionName = actionName;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.ErrorMsg = errorMsg;
            this.LogLocation = logLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTask" /> class.
        /// </summary>
        public WorkflowTask()
        {
        }
    }
}