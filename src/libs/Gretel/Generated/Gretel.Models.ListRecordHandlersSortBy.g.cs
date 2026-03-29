
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRecordHandlersSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRecordHandlersSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRecordHandlersSortBy value)
        {
            return value switch
            {
                ListRecordHandlersSortBy.Asc => "asc",
                ListRecordHandlersSortBy.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRecordHandlersSortBy? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListRecordHandlersSortBy.Asc,
                "desc" => ListRecordHandlersSortBy.Desc,
                _ => null,
            };
        }
    }
}