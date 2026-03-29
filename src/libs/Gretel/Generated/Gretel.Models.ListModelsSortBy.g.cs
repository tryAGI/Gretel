
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListModelsSortBy
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
    public static class ListModelsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListModelsSortBy value)
        {
            return value switch
            {
                ListModelsSortBy.Asc => "asc",
                ListModelsSortBy.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListModelsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListModelsSortBy.Asc,
                "desc" => ListModelsSortBy.Desc,
                _ => null,
            };
        }
    }
}