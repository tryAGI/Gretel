
#nullable enable

namespace Gretel
{
    /// <summary>
    /// Default runner mode
    /// </summary>
    public enum CreateProjectRequestRunnerMode
    {
        /// <summary>
        /// 
        /// </summary>
        Cloud,
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectRequestRunnerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestRunnerMode value)
        {
            return value switch
            {
                CreateProjectRequestRunnerMode.Cloud => "cloud",
                CreateProjectRequestRunnerMode.Hybrid => "hybrid",
                CreateProjectRequestRunnerMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestRunnerMode? ToEnum(string value)
        {
            return value switch
            {
                "cloud" => CreateProjectRequestRunnerMode.Cloud,
                "hybrid" => CreateProjectRequestRunnerMode.Hybrid,
                "manual" => CreateProjectRequestRunnerMode.Manual,
                _ => null,
            };
        }
    }
}