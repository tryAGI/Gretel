
#nullable enable

namespace Gretel
{
    /// <summary>
    /// Current handler status
    /// </summary>
    public enum RecordHandlerStatus
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
    public static class RecordHandlerStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RecordHandlerStatus value)
        {
            return value switch
            {
                RecordHandlerStatus.Active => "active",
                RecordHandlerStatus.Cancelled => "cancelled",
                RecordHandlerStatus.Completed => "completed",
                RecordHandlerStatus.Created => "created",
                RecordHandlerStatus.Error => "error",
                RecordHandlerStatus.Lost => "lost",
                RecordHandlerStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RecordHandlerStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => RecordHandlerStatus.Active,
                "cancelled" => RecordHandlerStatus.Cancelled,
                "completed" => RecordHandlerStatus.Completed,
                "created" => RecordHandlerStatus.Created,
                "error" => RecordHandlerStatus.Error,
                "lost" => RecordHandlerStatus.Lost,
                "pending" => RecordHandlerStatus.Pending,
                _ => null,
            };
        }
    }
}