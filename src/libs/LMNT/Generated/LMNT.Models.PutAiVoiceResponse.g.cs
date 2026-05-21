
#nullable enable

namespace LMNT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutAiVoiceResponse
    {
        /// <summary>
        /// Voice details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LMNT.Voice Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAiVoiceResponse" /> class.
        /// </summary>
        /// <param name="voice">
        /// Voice details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutAiVoiceResponse(
            global::LMNT.Voice voice)
        {
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAiVoiceResponse" /> class.
        /// </summary>
        public PutAiVoiceResponse()
        {
        }

    }
}