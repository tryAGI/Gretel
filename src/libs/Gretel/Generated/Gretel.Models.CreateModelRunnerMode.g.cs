
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelRunnerMode
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
    public static class CreateModelRunnerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRunnerMode value)
        {
            return value switch
            {
                CreateModelRunnerMode.Cloud => "cloud",
                CreateModelRunnerMode.Hybrid => "hybrid",
                CreateModelRunnerMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRunnerMode? ToEnum(string value)
        {
            return value switch
            {
                "cloud" => CreateModelRunnerMode.Cloud,
                "hybrid" => CreateModelRunnerMode.Hybrid,
                "manual" => CreateModelRunnerMode.Manual,
                _ => null,
            };
        }
    }
}