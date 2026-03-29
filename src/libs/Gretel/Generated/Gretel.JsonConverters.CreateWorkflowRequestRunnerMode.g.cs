#nullable enable

namespace Gretel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateWorkflowRequestRunnerModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gretel.CreateWorkflowRequestRunnerMode>
    {
        /// <inheritdoc />
        public override global::Gretel.CreateWorkflowRequestRunnerMode Read(
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
                        return global::Gretel.CreateWorkflowRequestRunnerModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gretel.CreateWorkflowRequestRunnerMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gretel.CreateWorkflowRequestRunnerMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gretel.CreateWorkflowRequestRunnerMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Gretel.CreateWorkflowRequestRunnerModeExtensions.ToValueString(value));
        }
    }
}
