
#nullable enable

namespace Gretel
{
    /// <summary>
    /// Parameters for record generation. For synthetic data, set num_records. For transforms, specify transform-specific params.
    /// </summary>
    public sealed partial class CreateRecordHandlerRequestParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}