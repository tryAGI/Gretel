
#nullable enable

namespace Gretel
{
    /// <summary>
    /// Runner mode for workflow execution
    /// </summary>
    public enum CreateWorkflowRequestRunnerMode
    {
        /// <summary>
        /// 
        /// </summary>
        RunnerModeCloud,
        /// <summary>
        /// 
        /// </summary>
        RunnerModeHybrid,
        /// <summary>
        /// 
        /// </summary>
        RunnerModeManual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWorkflowRequestRunnerModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowRequestRunnerMode value)
        {
            return value switch
            {
                CreateWorkflowRequestRunnerMode.RunnerModeCloud => "RUNNER_MODE_CLOUD",
                CreateWorkflowRequestRunnerMode.RunnerModeHybrid => "RUNNER_MODE_HYBRID",
                CreateWorkflowRequestRunnerMode.RunnerModeManual => "RUNNER_MODE_MANUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowRequestRunnerMode? ToEnum(string value)
        {
            return value switch
            {
                "RUNNER_MODE_CLOUD" => CreateWorkflowRequestRunnerMode.RunnerModeCloud,
                "RUNNER_MODE_HYBRID" => CreateWorkflowRequestRunnerMode.RunnerModeHybrid,
                "RUNNER_MODE_MANUAL" => CreateWorkflowRequestRunnerMode.RunnerModeManual,
                _ => null,
            };
        }
    }
}