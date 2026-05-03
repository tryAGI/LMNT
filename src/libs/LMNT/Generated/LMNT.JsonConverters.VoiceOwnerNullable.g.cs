#nullable enable

namespace LMNT.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoiceOwnerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LMNT.VoiceOwner?>
    {
        /// <inheritdoc />
        public override global::LMNT.VoiceOwner? Read(
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
                        return global::LMNT.VoiceOwnerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LMNT.VoiceOwner)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LMNT.VoiceOwner?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LMNT.VoiceOwner? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LMNT.VoiceOwnerExtensions.ToValueString(value.Value));
            }
        }
    }
}
