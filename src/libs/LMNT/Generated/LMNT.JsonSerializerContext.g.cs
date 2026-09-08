
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::LMNT.JsonConverters.ErrorResponseTypeJsonConverter),

            typeof(global::LMNT.JsonConverters.ErrorResponseTypeNullableJsonConverter),

            typeof(global::LMNT.JsonConverters.ErrorResponseErrorTypeJsonConverter),

            typeof(global::LMNT.JsonConverters.ErrorResponseErrorTypeNullableJsonConverter),

            typeof(global::LMNT.JsonConverters.VoiceOwnerJsonConverter),

            typeof(global::LMNT.JsonConverters.VoiceOwnerNullableJsonConverter),

            typeof(global::LMNT.JsonConverters.VoiceTypeJsonConverter),

            typeof(global::LMNT.JsonConverters.VoiceTypeNullableJsonConverter),

            typeof(global::LMNT.JsonConverters.OutputFormatJsonConverter),

            typeof(global::LMNT.JsonConverters.OutputFormatNullableJsonConverter),

            typeof(global::LMNT.JsonConverters.LanguageCodeJsonConverter),

            typeof(global::LMNT.JsonConverters.LanguageCodeNullableJsonConverter),

            typeof(global::LMNT.JsonConverters.ModelJsonConverter),

            typeof(global::LMNT.JsonConverters.ModelNullableJsonConverter),

            typeof(global::LMNT.JsonConverters.SpeechRequestJsonConverter),

            typeof(global::LMNT.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.ErrorResponseType), TypeInfoPropertyName = "ErrorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.ErrorResponseErrorType), TypeInfoPropertyName = "ErrorResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.VoiceOwner), TypeInfoPropertyName = "VoiceOwner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.VoiceType), TypeInfoPropertyName = "VoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.OutputFormat), TypeInfoPropertyName = "OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.LanguageCode), TypeInfoPropertyName = "LanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.Model), TypeInfoPropertyName = "Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.SpeechRequest), TypeInfoPropertyName = "SpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.StreamSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.SpeechRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.TimestampObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.UpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GenerateDetailedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LMNT.TimestampObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.DeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.UpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LMNT.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.RetrieveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.RetrieveResponsePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.RetrieveResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LMNT.TimestampObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LMNT.Voice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}