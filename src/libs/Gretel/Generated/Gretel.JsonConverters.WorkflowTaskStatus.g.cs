#nullable enable

namespace Gretel.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkflowTaskStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gretel.WorkflowTaskStatus>
    {
        /// <inheritdoc />
        public override global::Gretel.WorkflowTaskStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Gretel.WorkflowTaskStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gretel.WorkflowTaskStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gretel.WorkflowTaskStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gretel.WorkflowTaskStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Gretel.WorkflowTaskStatusExtensions.ToValueString(value));
        }
    }
}
