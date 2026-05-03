
#nullable enable

namespace LMNT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAiSpeechResponse
    {
        /// <summary>
        /// The base64-encoded audio file; the format is determined by the `format` parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// A JSON object outlining the spoken duration of each synthesized input element (words and non-words like spaces, punctuation, etc.). See an [example of this object](https://imgur.com/Uw6qNzY.png) for the input string "Hello world!"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durations")]
        public global::System.Collections.Generic.IList<global::LMNT.DurationObject>? Durations { get; set; }

        /// <summary>
        /// The seed used to generate this speech; can be used to replicate this output take (assuming the same text is resynthsized with this seed number, [see here](http://docs.lmnt.com/speech/seed) for more details).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiSpeechResponse" /> class.
        /// </summary>
        /// <param name="audio">
        /// The base64-encoded audio file; the format is determined by the `format` parameter.
        /// </param>
        /// <param name="seed">
        /// The seed used to generate this speech; can be used to replicate this output take (assuming the same text is resynthsized with this seed number, [see here](http://docs.lmnt.com/speech/seed) for more details).
        /// </param>
        /// <param name="durations">
        /// A JSON object outlining the spoken duration of each synthesized input element (words and non-words like spaces, punctuation, etc.). See an [example of this object](https://imgur.com/Uw6qNzY.png) for the input string "Hello world!"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAiSpeechResponse(
            string audio,
            int seed,
            global::System.Collections.Generic.IList<global::LMNT.DurationObject>? durations)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Durations = durations;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiSpeechResponse" /> class.
        /// </summary>
        public CreateAiSpeechResponse()
        {
        }
    }
}