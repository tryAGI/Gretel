
#nullable enable

namespace Gretel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecordHandlerRequest
    {
        /// <summary>
        /// Reference to the data source artifact
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source")]
        public string? DataSource { get; set; }

        /// <summary>
        /// Parameters for record generation. For synthetic data, set num_records. For transforms, specify transform-specific params.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordHandlerRequest" /> class.
        /// </summary>
        /// <param name="dataSource">
        /// Reference to the data source artifact
        /// </param>
        /// <param name="params">
        /// Parameters for record generation. For synthetic data, set num_records. For transforms, specify transform-specific params.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecordHandlerRequest(
            string? dataSource,
            object? @params)
        {
            this.DataSource = dataSource;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordHandlerRequest" /> class.
        /// </summary>
        public CreateRecordHandlerRequest()
        {
        }
    }
}