
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.VoiceOwner), TypeInfoPropertyName = "VoiceOwner2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.VoiceType), TypeInfoPropertyName = "VoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.OutputFormat), TypeInfoPropertyName = "OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.LanguageCode), TypeInfoPropertyName = "LanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.Model), TypeInfoPropertyName = "Model2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.SpeechRequest), TypeInfoPropertyName = "SpeechRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.StreamSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.SpeechRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.DurationObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.PutAiVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiSpeechConvertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GetAccountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GetAccountResponsePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GetAccountResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GetAccountResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GetAccountResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LMNT.DurationObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiSpeechResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiSpeechResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiSpeechBytesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiSpeechBytesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LMNT.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GetAiVoiceListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GetAiVoiceListResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.DeleteAiVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.DeleteAiVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.DeleteAiVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GetAiVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.GetAiVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.PutAiVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.PutAiVoiceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.PutAiVoiceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiSpeechConvertResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LMNT.CreateAiSpeechConvertResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LMNT.DurationObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LMNT.Voice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}