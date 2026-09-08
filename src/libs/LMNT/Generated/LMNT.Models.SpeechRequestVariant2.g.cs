
#nullable enable

namespace LMNT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechRequestVariant2
    {
        /// <summary>
        /// If set as `true`, the response will contain a `timestamps` array describing where each input element falls in the generated audio.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_timestamps")]
        public bool? ReturnTimestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequestVariant2" /> class.
        /// </summary>
        /// <param name="returnTimestamps">
        /// If set as `true`, the response will contain a `timestamps` array describing where each input element falls in the generated audio.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRequestVariant2(
            bool? returnTimestamps)
        {
            this.ReturnTimestamps = returnTimestamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequestVariant2" /> class.
        /// </summary>
        public SpeechRequestVariant2()
        {
        }

    }
}