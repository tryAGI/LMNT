
#nullable enable

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateDetailedResponse
    {
        /// <summary>
        /// The base64-encoded audio file; the format is determined by the `format` parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// An array describing where each generated input element (words and non-words like spaces, punctuation, etc.) falls in the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamps")]
        public global::System.Collections.Generic.IList<global::LMNT.TimestampObject>? Timestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDetailedResponse" /> class.
        /// </summary>
        /// <param name="audio">
        /// The base64-encoded audio file; the format is determined by the `format` parameter.
        /// </param>
        /// <param name="timestamps">
        /// An array describing where each generated input element (words and non-words like spaces, punctuation, etc.) falls in the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateDetailedResponse(
            string audio,
            global::System.Collections.Generic.IList<global::LMNT.TimestampObject>? timestamps)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Timestamps = timestamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDetailedResponse" /> class.
        /// </summary>
        public GenerateDetailedResponse()
        {
        }

    }
}