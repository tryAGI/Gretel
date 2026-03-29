
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteAccountDryRun
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
    public static class DeleteAccountDryRunExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAccountDryRun value)
        {
            return value switch
            {
                DeleteAccountDryRun.No => "no",
                DeleteAccountDryRun.Yes => "yes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAccountDryRun? ToEnum(string value)
        {
            return value switch
            {
                "no" => DeleteAccountDryRun.No,
                "yes" => DeleteAccountDryRun.Yes,
                _ => null,
            };
        }
    }
}