#nullable enable

namespace Gretel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateProjectRequestRunnerModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Gretel.CreateProjectRequestRunnerMode?>
    {
        /// <inheritdoc />
        public override global::Gretel.CreateProjectRequestRunnerMode? Read(
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
                        return global::Gretel.CreateProjectRequestRunnerModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Gretel.CreateProjectRequestRunnerMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Gretel.CreateProjectRequestRunnerMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Gretel.CreateProjectRequestRunnerMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Gretel.CreateProjectRequestRunnerModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
