
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowTaskStatus
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
    public static class WorkflowTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowTaskStatus value)
        {
            return value switch
            {
                WorkflowTaskStatus.Active => "active",
                WorkflowTaskStatus.Cancelled => "cancelled",
                WorkflowTaskStatus.Completed => "completed",
                WorkflowTaskStatus.Created => "created",
                WorkflowTaskStatus.Error => "error",
                WorkflowTaskStatus.Lost => "lost",
                WorkflowTaskStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => WorkflowTaskStatus.Active,
                "cancelled" => WorkflowTaskStatus.Cancelled,
                "completed" => WorkflowTaskStatus.Completed,
                "created" => WorkflowTaskStatus.Created,
                "error" => WorkflowTaskStatus.Error,
                "lost" => WorkflowTaskStatus.Lost,
                "pending" => WorkflowTaskStatus.Pending,
                _ => null,
            };
        }
    }
}