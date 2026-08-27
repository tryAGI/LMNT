#nullable enable

namespace LMNT.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LMNT.Model>
    {
        /// <inheritdoc />
        public override global::LMNT.Model Read(
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
                        return global::LMNT.ModelExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LMNT.Model)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LMNT.Model);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LMNT.Model value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LMNT.ModelExtensions.ToValueString(value));
        }
    }
}
