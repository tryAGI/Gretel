
#nullable enable

namespace Gretel
{
    /// <summary>
    /// Current model status
    /// </summary>
    public enum ModelStatus
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
    public static class ModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelStatus value)
        {
            return value switch
            {
                ModelStatus.Active => "active",
                ModelStatus.Cancelled => "cancelled",
                ModelStatus.Completed => "completed",
                ModelStatus.Created => "created",
                ModelStatus.Error => "error",
                ModelStatus.Lost => "lost",
                ModelStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ModelStatus.Active,
                "cancelled" => ModelStatus.Cancelled,
                "completed" => ModelStatus.Completed,
                "created" => ModelStatus.Created,
                "error" => ModelStatus.Error,
                "lost" => ModelStatus.Lost,
                "pending" => ModelStatus.Pending,
                _ => null,
            };
        }
    }
}