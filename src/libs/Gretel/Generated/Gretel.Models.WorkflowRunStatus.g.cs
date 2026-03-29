
#nullable enable

namespace Gretel
{
    /// <summary>
    /// Current run status
    /// </summary>
    public enum WorkflowRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Lost,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowRunStatus value)
        {
            return value switch
            {
                WorkflowRunStatus.Active => "active",
                WorkflowRunStatus.Cancelled => "cancelled",
                WorkflowRunStatus.Completed => "completed",
                WorkflowRunStatus.Created => "created",
                WorkflowRunStatus.Error => "error",
                WorkflowRunStatus.Lost => "lost",
                WorkflowRunStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => WorkflowRunStatus.Active,
                "cancelled" => WorkflowRunStatus.Cancelled,
                "completed" => WorkflowRunStatus.Completed,
                "created" => WorkflowRunStatus.Created,
                "error" => WorkflowRunStatus.Error,
                "lost" => WorkflowRunStatus.Lost,
                "pending" => WorkflowRunStatus.Pending,
                _ => null,
            };
        }
    }
}