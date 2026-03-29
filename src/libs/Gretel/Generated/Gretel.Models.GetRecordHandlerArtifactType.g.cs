
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRecordHandlerArtifactType
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
        Report,
        /// <summary>
        /// 
        /// </summary>
        ReportJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRecordHandlerArtifactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRecordHandlerArtifactType value)
        {
            return value switch
            {
                GetRecordHandlerArtifactType.Data => "data",
                GetRecordHandlerArtifactType.Logs => "logs",
                GetRecordHandlerArtifactType.Report => "report",
                GetRecordHandlerArtifactType.ReportJson => "report_json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRecordHandlerArtifactType? ToEnum(string value)
        {
            return value switch
            {
                "data" => GetRecordHandlerArtifactType.Data,
                "logs" => GetRecordHandlerArtifactType.Logs,
                "report" => GetRecordHandlerArtifactType.Report,
                "report_json" => GetRecordHandlerArtifactType.ReportJson,
                _ => null,
            };
        }
    }
}