
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelArtifactType
    {
        /// <summary>
        /// 
        /// </summary>
        Data,
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Report,
        /// <summary>
        /// 
        /// </summary>
        ReportJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelArtifactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelArtifactType value)
        {
            return value switch
            {
                GetModelArtifactType.Data => "data",
                GetModelArtifactType.Logs => "logs",
                GetModelArtifactType.Model => "model",
                GetModelArtifactType.Report => "report",
                GetModelArtifactType.ReportJson => "report_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelArtifactType? ToEnum(string value)
        {
            return value switch
            {
                "data" => GetModelArtifactType.Data,
                "logs" => GetModelArtifactType.Logs,
                "model" => GetModelArtifactType.Model,
                "report" => GetModelArtifactType.Report,
                "report_json" => GetModelArtifactType.ReportJson,
                _ => null,
            };
        }
    }
}