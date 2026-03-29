
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRecordHandlersStatus
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
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRecordHandlersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRecordHandlersStatus value)
        {
            return value switch
            {
                ListRecordHandlersStatus.Active => "active",
                ListRecordHandlersStatus.Cancelled => "cancelled",
                ListRecordHandlersStatus.Completed => "completed",
                ListRecordHandlersStatus.Created => "created",
                ListRecordHandlersStatus.Error => "error",
                ListRecordHandlersStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRecordHandlersStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListRecordHandlersStatus.Active,
                "cancelled" => ListRecordHandlersStatus.Cancelled,
                "completed" => ListRecordHandlersStatus.Completed,
                "created" => ListRecordHandlersStatus.Created,
                "error" => ListRecordHandlersStatus.Error,
                "pending" => ListRecordHandlersStatus.Pending,
                _ => null,
            };
        }
    }
}