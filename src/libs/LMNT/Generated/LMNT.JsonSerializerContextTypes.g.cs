
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::LMNT.ErrorResponse? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.ErrorResponseType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.ErrorResponseError? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.ErrorResponseErrorType? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.Voice? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.VoiceOwner? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.VoiceType? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.OutputFormat? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.LanguageCode? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.Model? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.SpeechRequest? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.StreamSpeechRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.SpeechRequestVariant2? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.TimestampObject? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.CreateRequest? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.UpdateRequest? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.GenerateDetailedResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LMNT.TimestampObject>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.DeleteResponse? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.UpdateResponse? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LMNT.Voice>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.RetrieveResponse? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.RetrieveResponsePlan? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LMNT.RetrieveResponseUsage? Type29 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LMNT.TimestampObject>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LMNT.Voice>? ListType2 { get; set; }
    }
}