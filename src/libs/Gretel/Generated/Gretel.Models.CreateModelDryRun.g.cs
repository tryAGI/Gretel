
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelDryRun
    {
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// 
        /// </summary>
        Yes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelDryRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelDryRun value)
        {
            return value switch
            {
                CreateModelDryRun.No => "no",
                CreateModelDryRun.Yes => "yes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelDryRun? ToEnum(string value)
        {
            return value switch
            {
                "no" => CreateModelDryRun.No,
                "yes" => CreateModelDryRun.Yes,
                _ => null,
            };
        }
    }
}