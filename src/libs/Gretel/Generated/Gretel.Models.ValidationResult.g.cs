
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidationResult
    {
        /// <summary>
        /// Whether the validation passed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        public bool? Valid { get; set; }

        /// <summary>
        /// List of validation errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// List of validation warnings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult" /> class.
        /// </summary>
        /// <param name="valid">
        /// Whether the validation passed
        /// </param>
        /// <param name="errors">
        /// List of validation errors
        /// </param>
        /// <param name="warnings">
        /// List of validation warnings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationResult(
            bool? valid,
            global::System.Collections.Generic.IList<string>? errors,
            global::System.Collections.Generic.IList<string>? warnings)
        {
            this.Valid = valid;
            this.Errors = errors;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult" /> class.
        /// </summary>
        public ValidationResult()
        {
        }
    }
}